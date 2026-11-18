using Frosty.Core.Attributes;
using RevertFolderPlugin;
using System.Runtime.InteropServices;
using System.Windows;

[assembly: ComVisible(false)]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,
    ResourceDictionaryLocation.SourceAssembly
)]

[assembly: PluginDisplayName("Revert Folder")]
[assembly: PluginAuthor("Aigni")]
[assembly: PluginVersion("1.0.1.0")]

[assembly: RegisterDataExplorerContextMenu(typeof(RevertFolderContextMenuItem))]
