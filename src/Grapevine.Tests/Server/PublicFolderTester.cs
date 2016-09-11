﻿using System.IO;
using Grapevine.Server;
using Shouldly;
using Xunit;

namespace Grapevine.Tests.Server
{
    public class PublicFolderTester
    {
        [Fact]
        public void public_folder_default_index_is_index_dot_html()
        {
            var root = new PublicFolder();
            root.DefaultFileName.ShouldBe("index.html");
        }

        [Fact]
        public void public_folder_default_index_can_be_changed()
        {
            var root = new PublicFolder { DefaultFileName = "default.html" };
            root.DefaultFileName.ShouldBe("default.html");
        }

        [Fact]
        public void public_folder_default_folder_is_webroot()
        {
            var root = new PublicFolder();
            root.FolderPath.EndsWith("public").ShouldBe(true);
        }

        [Fact]
        public void public_folder_default_folder_can_be_changed()
        {
            var newdir = "newdir";
            if (Directory.Exists(newdir)) Directory.Delete(newdir);

            var root = new PublicFolder { FolderPath = newdir };
            root.FolderPath.EndsWith(newdir).ShouldBe(true);
        }

        [Fact]
        public void public_folder_create_folder_returns_null_when_string_is_null_or_empty()
        {

        }
    }
}
