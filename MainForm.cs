using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AreTheseFoldersInDropbox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Restore();

            Closing += (sender, args) => Save();
        }

        private void dropboxFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            dropboxFolderTxt.Text = dlg.SelectedPath;
        }

        private void folderBrowseBtn_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            folderTxt.Text = dlg.SelectedPath;
        }

        private void Restore()
        {
            var softwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
            var appNameKey = softwareKey?.CreateSubKey("AreTheseFoldersInDropbox");

            folderTxt.Text = appNameKey?.GetValue("folder", "") as string ?? "";
            dropboxFolderTxt.Text = appNameKey?.GetValue("dropboxFolder", "") as string ?? "";
            searchPattern.Text = appNameKey?.GetValue("searchPattern", "*") as string ?? "*";
           
            bool folderRecurseSetting;
            if (bool.TryParse(appNameKey?.GetValue("folderRecurse", false) as string ?? "", out folderRecurseSetting))
                folderRecurse.Checked = folderRecurseSetting;

            bool dropboxFolderRecurseSetting;
            if (bool.TryParse(appNameKey?.GetValue("dropboxFolderRecurse", false) as string ?? "", out dropboxFolderRecurseSetting))
                dropboxFolderRecurse.Checked = dropboxFolderRecurseSetting;

            bool copyMissingSetting;
            if (bool.TryParse(appNameKey?.GetValue("copyMissing", false) as string ?? "", out copyMissingSetting))
                copyMissing.Checked = copyMissingSetting;
        }

        private void Save()
        {
            var softwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
            var appNameKey = softwareKey?.CreateSubKey("AreTheseFoldersInDropbox");

            appNameKey?.SetValue("folder", folderTxt.Text);
            appNameKey?.SetValue("folderRecurse", folderRecurse.Checked);
            appNameKey?.SetValue("dropboxFolder", dropboxFolderTxt.Text);
            appNameKey?.SetValue("dropboxFolderRecurse", dropboxFolderRecurse.Checked);
            appNameKey?.SetValue("searchPattern", searchPattern.Text);
            appNameKey?.SetValue("copyMissing", copyMissing.Checked);
        }

        private async void goBtn_Click(object sender, EventArgs e)
        {
            goBtn.Enabled = false;
            resultsTxt.Text = "";
            try
            {
                var dropBoxFiles = await ReadDropBoxFiles();
                var missingFiles = await LookForMissingFiles(dropBoxFiles);

                resultsTxt.Text += $"{missingFiles.Count} files missing\r\n";
                foreach (var missingFile in missingFiles)
                {
                    resultsTxt.Text += $"File missing: {missingFile.FullName}\r\n";
                }

                if (copyMissing.Checked)
                {
                    await CopyMissingFiles(missingFiles);
                }
            }
            catch (Exception exception)
            {
                resultsTxt.Text += $"Exception: {exception}";
            }
            goBtn.Enabled = true;
        }

        private async Task CopyMissingFiles(List<FileInfo> missingFiles)
        {
            var destination = dropboxFolderTxt.Text;
            foreach (var missingFile in missingFiles)
            {
                resultsTxt.Text += $"Copying: {missingFile.FullName}\r\n";
                await Task.Run(()=>missingFile.CopyTo($"{destination}{Path.DirectorySeparatorChar}{missingFile.Name}", false));
            }
        }

        private async Task<List<FileInfo>> LookForMissingFiles(Dictionary<string, FileInfo> dropBoxFiles)
        {
            var searchOptions = folderRecurse.Checked
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;

            resultsTxt.Text += "Reading new files\r\n";
            var files2 = await Task.Run(() => new DirectoryInfo(folderTxt.Text).GetFiles(searchPattern.Text,
                searchOptions));

            resultsTxt.Text += "Hashing and comparing new files\r\n";
            var missingFiles = new List<FileInfo>();
            foreach (var fileInfo in files2)
            {
                try
                {
                    if (!dropBoxFiles.ContainsKey(await CaclculateMd5(fileInfo)))
                        missingFiles.Add(fileInfo);
                }
                catch (Exception exception)
                {
                    resultsTxt.Text += $"Exception processing {fileInfo.FullName}: {exception}\r\n";
                }
            }
            return missingFiles;
        }

        private async Task<Dictionary<string, FileInfo>> ReadDropBoxFiles()
        {
            var searchOptions = dropboxFolderRecurse.Checked
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;

            resultsTxt.Text += "Reading DropBox files\r\n";
            var files1 = await Task.Run(() => new DirectoryInfo(dropboxFolderTxt.Text).GetFiles(searchPattern.Text,
                searchOptions));

            resultsTxt.Text += $"Hashing {files1.Length} files\r\n";

            var dropBoxFiles = new Dictionary<string, FileInfo>();
            foreach (var fileInfo in files1)
            {
                try
                {
                    dropBoxFiles.Add(await CaclculateMd5(fileInfo), fileInfo);
                }
                catch (Exception exception)
                {
                    resultsTxt.Text += $"Exception copying {fileInfo.FullName}: {exception}\r\n";
                }
            }
            return dropBoxFiles;
        }

        private Task<string> CaclculateMd5(FileInfo file)
        {
            return Task.Run(() =>
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(file.FullName))
                    {
                        return BitConverter.ToString(md5.ComputeHash(stream));
                    }
                }
            });
        }
    }
}