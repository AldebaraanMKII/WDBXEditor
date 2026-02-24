# Project Map

This document provides an automatically generated map of the C# script files in the repository, including general descriptions for each file and inferred descriptions for classes, properties, and methods. Descriptions are largely based on naming conventions and may not cover the full complexity of the code.

## File: AdvancedDataGridView\AdvancedDataGridView.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting.

### Class: AdvancedDataGridView
  **Description**: Advanced Data Grid View type definition.

  **Properties**:
  * `HeaderContext` (`ContextMenu`): Header Context property.
  * `FilterAndSortEnabled` (`bool`): Filter And Sort Enabled property.
  * `FilterString` (`string`): Filter String property.
  * `SortString` (`string`): Sort String property.
  * `FilterableCells` (`IEnumerable<ColumnHeader>`): Filterable Cells property.

  **Methods**:
  * `SetEvents(DataGridViewColumnHeaderCell header)` (`void`): Set Events method.
  * `SelectRow(int index)` (`void`): Select Row method.
  * `ValidValue(int index, object value)` (`bool`): Valid Value method.
  * `BuildFilterString()` (`string`): Build Filter String method.
  * `cell_FilterPopup(object sender, ColumnHeaderCellEventArgs e)` (`void`): Cell Filter Popup method.
  * `cell_FilterChanged(object sender, ColumnHeaderCellEventArgs e)` (`void`): Cell Filter Changed method.
  * `BuildSortString()` (`string`): Build Sort String method.
  * `cell_SortChanged(object sender, ColumnHeaderCellEventArgs e)` (`void`): Cell Sort Changed method.
  * `cell_HideChanged(object sender, ColumnHeaderCellEventArgs e)` (`void`): Cell Hide Changed method.
  * `cell_HexChanged(object sender, ColumnHeaderCellEventArgs e)` (`void`): Cell Hex Changed method.
  * `SetCopyData()` (`void`): Set Copy Data method.
  * `PasteCopyData(DataRow row)` (`void`): Paste Copy Data method.
  * `ClearCopyData()` (`void`): Clear Copy Data method.
  * `SetVisible(int index, bool value)` (`void`): Set Visible method.
  * `BuildMinMaxArray()` (`void`): Build Min Max Array method.

### Internal Class: MinMax
  **Description**: Min Max type definition.

  **Properties**:
  * `MinVal` (`object`): Min Val property.
  * `MaxVal` (`object`): Max Val property.
  * `Signed` (`bool`): Signed property.
  * `IsSingle` (`bool`): Is Single property.

---

## File: AdvancedDataGridView\ChangeTracking.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting.

### Class: ChangeTracking
  **Description**: Change Tracking type definition.

  **Properties**:
  * `Added` (`int`): Added property.
  * `Removed` (`int`): Removed property.
  * `Changed` (`int`): Changed property.

  **Methods**:
  * `Add(object o)` (`void`): Add method.
  * `Remove(object o)` (`void`): Remove method.
  * `Change(object o)` (`void`): Change method.
  * `Contains(object o)` (`bool`): Contains method.

---

## File: AdvancedDataGridView\ColumnHeader.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting.

### Class: ColumnHeader
  **Description**: Column Header type definition.

  **Properties**:
  * `FilterAndSortEnabled` (`bool`): Filter And Sort Enabled property.
  * `FilterString` (`string`): Filter String property.
  * `SortString` (`string`): Sort String property.
  * `ActiveFilterType` (`ColumnMenu.FilterType`): Active Filter Type property.
  * `ActiveSortType` (`ColumnMenu.SortType`): Active Sort Type property.
  * `MinimumSize` (`Size`): Minimum Size property.
  * `FilterChanged` (`ColumnHeaderCellEventHandler`): Filter Changed property.
  * `SortChanged` (`ColumnHeaderCellEventHandler`): Sort Changed property.
  * `FilterPopup` (`ColumnHeaderCellEventHandler`): Filter Popup property.
  * `HideChanged` (`ColumnHeaderCellEventHandler`): Hide Changed property.
  * `HexChanged` (`ColumnHeaderCellEventHandler`): Hex Changed property.

  **Methods**:
  * `ColumnHeader(DataGridViewColumnHeaderCell headerCell)` (`void`): Column Header method.
  * `ColumnHeader(DataGridViewColumnHeaderCell headerCell, bool filterAndSortEnabled)` (`void`): Column Header method.
  * `Get(int x, int y)` (`bool`): Get method.
  * `Reset()` (`void`): Reset method.
  * `Dispose(bool disposing)` (`void`): Dispose method.

### Delegate: ColumnHeaderCellEventHandler
  **Description**: Column Header Cell Event Handler type definition.

### Class: ColumnHeaderCellEventArgs
  **Description**: Column Header Cell Event Args type definition.

  **Properties**:
  * `FilterMenu` (`ColumnMenu`): Filter Menu property.
  * `Column` (`DataGridViewColumn`): Column property.

  **Methods**:
  * `ColumnHeaderCellEventArgs(ColumnMenu filterMenu, DataGridViewColumn column)` (`void`): Column Header Cell Event Args method.

---

## File: AdvancedDataGridView\ColumnMenu.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting.

### Class: ColumnMenu
  **Description**: Column Menu type definition.

  **Properties**:
  * `ActiveFilterType` (`FilterType`): Active Filter Type property.
  * `ActiveSortType` (`SortType`): Active Sort Type property.
  * `SortString` (`string`): Sort String property.
  * `FilterString` (`string`): Filter String property.
  * `FilterChanged` (`EventHandler`): Filter Changed property.
  * `SortChanged` (`EventHandler`): Sort Changed property.
  * `HideChanged` (`EventHandler`): Hide Changed property.
  * `HexChanged` (`EventHandler`): Hex Changed property.

  **Methods**:
  * `ColumnMenu(DataGridViewColumn column)` (`void`): Column Menu method.
  * `Show(DataGridView dgv, int x, int y, bool generateValues)` (`void`): Show method.
  * `Show(DataGridView dgv, int x, int y, List<string> values)` (`void`): Show method.
  * `GetValuesForFilter(DataGridView dgv, string column)` (`List<string>`): Get Values For Filter method.

### Enum: FilterType
  **Description**: Filter Type type definition.

  **Members**:
  * `None`: None member.
  * `Custom`: Custom member.
  * `Value`: Value member.

### Enum: SortType
  **Description**: Sort Type type definition.

  **Members**:
  * `None`: None member.
  * `Ascending`: Ascending member.
  * `Descending`: Descending member.

---

## File: AdvancedDataGridView\ColumnMenu.designer.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting. This is a designer-generated file, typically containing UI component initialization code.

### Class: ColumnMenu
  **Description**: Column Menu type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: AdvancedDataGridView\DataCache.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting.

### Class: DataCache
  **Description**: Data Cache type definition.

  **Methods**:
  * `Add(string key, object value)` (`void`): Add method.
  * `Get(string key)` (`object`): Get method.
  * `Clear()` (`void`): Clear method.

---

## File: AdvancedDataGridView\FilterForm.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting.

### Class: FilterForm
  **Description**: Filter Form type definition.

  **Properties**:
  * `Column` (`DataGridViewColumn`): Column property.
  * `FilterType` (`ColumnMenu.FilterType`): Filter Type property.
  * `FilterString` (`string`): Filter String property.

  **Methods**:
  * `FilterForm(DataGridViewColumn column)` (`void`): Filter Form method.
  * `FilterForm(DataGridViewColumn column, string filter)` (`void`): Filter Form method.

---

## File: AdvancedDataGridView\FilterForm.Designer.cs
**General Description**: This file is part of the AdvancedDataGridView component, extending the standard DataGridView with features like filtering and sorting. This is a designer-generated file, typically containing UI component initialization code.

### Class: FilterForm
  **Description**: Filter Form type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: AdvancedDataGridView\obj\Debug\.NETFramework,Version=v4.8.AssemblyAttributes.cs
**General Description**: This file is a build artifact and contains assembly attributes for the project.

---

## File: AdvancedDataGridView\Properties\AssemblyInfo.cs
**General Description**: This file contains project properties, such as assembly information or resources.

---

## File: AdvancedDataGridView\Properties\Resources.Designer.cs
**General Description**: This file contains project properties, such as assembly information or resources.

### Class: Resources
  **Description**: Resources type definition.

  **Properties**:
  * `ResourceManager` (`ResourceManager`): Resource Manager property.
  * `Culture` (`CultureInfo`): Culture property.
  * `SortAscending` (`Bitmap`): Sort Ascending property.
  * `SortDescending` (`Bitmap`): Sort Descending property.
  * `SortFilter` (`Bitmap`): Sort Filter property.
  * `SortFilterAscending` (`Bitmap`): Sort Filter Ascending property.
  * `SortFilterDescending` (`Bitmap`): Sort Filter Descending property.

  **Methods**:
  * `get_ResourceManager()` (`ResourceManager`): Get Resource Manager method.
  * `set_Culture(CultureInfo value)` (`void`): Set Culture method.
  * `get_SortAscending()` (`Bitmap`): Get Sort Ascending method.
  * `get_SortDescending()` (`Bitmap`): Get Sort Descending method.
  * `get_SortFilter()` (`Bitmap`): Get Sort Filter method.
  * `get_SortFilterAscending()` (`Bitmap`): Get Sort Filter Ascending method.
  * `get_SortFilterDescending()` (`Bitmap`): Get Sort Filter Descending method.

---

## File: WDBXEditor\About.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: About
  **Description**: About type definition.

  **Methods**:
  * `About()` (`void`): About method.
  * `OnUpdateCheckCompleted(object sender, EventArgs e)` (`void`): On Update Check Completed method.

---

## File: WDBXEditor\About.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: About
  **Description**: About type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Archives\CASC\Constants\Locales.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: Locales
  **Description**: Locales type definition.

  **Properties**:
  * `All` (`string[]`): All property.
  * `String` (`string[]`): String property.
  * `Flags` (`LocaleFlags`): Flags property.

  **Methods**:
  * `GetLocaleFlags(string locale)` (`LocaleFlags`): Get Locale Flags method.

### Enum: LocaleFlags
  **Description**: Locale Flags type definition.

  **Members**:
  * `All`: All member.
  * `None`: None member.
  * `Unk1`: Unk1 member.
  * `enUS`: En US member.
  * `koKR`: Ko KR member.
  * `frFR`: Fr FR member.
  * `deDE`: De DE member.
  * `zhCN`: Zh CN member.
  * `esES`: Es ES member.
  * `zhTW`: Zh TW member.
  * `enGB`: En GB member.
  * `enCN`: En CN member.
  * `enTW`: En TW member.
  * `esMX`: Es MX member.
  * `ruRU`: Ru RU member.
  * `ptBR`: Pt BR member.
  * `itIT`: It IT member.
  * `ptPT`: Pt PT member.

---

## File: WDBXEditor\Archives\CASC\Handlers\BuildConfig.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: BuildConfig
  **Description**: Build Config type definition.

  **Properties**:
  * `Hash` (`byte[]`): Hash property.
  * `ArchiveGroup` (`string`): Archive Group property.
  * `Archives` (`string[]`): Archives property.
  * `BuildName` (`string`): Build Name property.
  * `CDNPath` (`string`): CDN Path property.
  * `Root` (`byte[]`): Root property.
  * `Download` (`string`): Download property.
  * `Install` (`string`): Install property.
  * `Size` (`string`): Size property.
  * `Encoding` (`string`): Encoding property.
  * `Patch` (`string`): Patch property.

  **Methods**:
  * `BuildConfig(byte[] hash)` (`void`): Build Config method.

---

## File: WDBXEditor\Archives\CASC\Handlers\BuildInfo.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: BuildInfo
  **Description**: Build Info type definition.

  **Properties**:
  * `Region` (`string`): Region property.
  * `CDN` (`string`): CDN property.
  * `VersionsName` (`string`): Versions Name property.
  * `BuildKey` (`byte[]`): Build Key property.
  * `CDNKey` (`byte[]`): CDN Key property.
  * `CASCKey` (`byte[]`): CASC Key property.
  * `BuildId` (`int`): Build Id property.
  * `Hotfixes` (`bool`): Hotfixes property.

  **Methods**:
  * `BuildInfo(string line)` (`void`): Build Info method.

---

## File: WDBXEditor\Archives\CASC\Handlers\CASCHandler.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: CASCHandler
  **Description**: CASC Handler type definition.

  **Properties**:
  * `BuildInfo` (`BuildInfo`): Build Info property.
  * `BuildId` (`int`): Build Id property.
  * `Config` (`BuildConfig`): Config property.
  * `Root` (`RootFile`): Root property.
  * `Encoding` (`EncodingFile`): Encoding property.
  * `DataFolder` (`string`): Data Folder property.
  * `ArchiveFolder` (`string`): Archive Folder property.
  * `Online` (`bool`): Online property.

  **Methods**:
  * `Initialize(string dataFolder, string archiveFolder)` (`void`): Initialize method.
  * `InitializeOnline(BuildInfo build)` (`void`): Initialize Online method.
  * `GetFile(byte[] hash)` (`byte[]`): Get File method.
  * `GetInstallInfo()` (`List<InstallInfo>`): Get Install Info method.

### Class: InstallInfo
  **Description**: Install Info type definition.

  **Properties**:
  * `Name` (`string`): Name property.
  * `Hash` (`byte[]`): Hash property.

  **Methods**:
  * `InstallInfo(string line)` (`void`): Install Info method.

---

## File: WDBXEditor\Archives\CASC\Handlers\CDNConfig.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: CDNConfig
  **Description**: CDN Config type definition.

  **Properties**:
  * `Hash` (`byte[]`): Hash property.
  * `Archives` (`string[]`): Archives property.
  * `ArchiveGroup` (`string`): Archive Group property.
  * `Hosts` (`string[]`): Hosts property.
  * `PatchUrl` (`string`): Patch Url property.

  **Methods**:
  * `CDNConfig(byte[] hash)` (`void`): CDN Config method.

---

## File: WDBXEditor\Archives\CASC\Handlers\DataFile.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: DataFile
  **Description**: Data File type definition.

  **Methods**:
  * `DataFile(int index)` (`void`): Data File method.
  * `OpenFile()` (`FileStream`): Open File method.
  * `ReadHash(byte[] hash, long offset, int size)` (`byte[]`): Read Hash method.

---

## File: WDBXEditor\Archives\CASC\Handlers\EncodingFile.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: EncodingFile
  **Description**: Encoding File type definition.

  **Properties**:
  * `Hash` (`byte[]`): Hash property.
  * `Entries` (`ConcurrentDictionary<byte[], EncodingEntry>`): Entries property.
  * `FooterHash` (`byte[]`): Footer Hash property.

  **Methods**:
  * `EncodingFile(byte[] hash)` (`void`): Encoding File method.
  * `GetEntries(byte[] hash)` (`IEnumerable<EncodingEntry>`): Get Entries method.

---

## File: WDBXEditor\Archives\CASC\Handlers\IndexFile.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: IndexFile
  **Description**: Index File type definition.

  **Properties**:
  * `Entries` (`IndexEntry[]`): Entries property.

  **Methods**:
  * `IndexFile(string path)` (`void`): Index File method.
  * `GetEntries(byte[] hash)` (`IndexEntry`): Get Entries method.

---

## File: WDBXEditor\Archives\CASC\Handlers\RootFile.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: RootFile
  **Description**: Root File type definition.

  **Properties**:
  * `RootEntries` (`ConcurrentDictionary<ulong, RootEntry>`): Root Entries property.

  **Methods**:
  * `RootFile(byte[] hash)` (`void`): Root File method.
  * `GetEntries(ulong hash)` (`RootEntry[]`): Get Entries method.
  * `GetEntries(byte[] hash)` (`RootEntry`): Get Entries method.

---

## File: WDBXEditor\Archives\CASC\Misc\ByteArrayComparer.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: ByteArrayComparer
  **Description**: Byte Array Comparer type definition.

  **Methods**:
  * `Equals(byte[] x, byte[] y)` (`bool`): Equals method.
  * `GetHashCode(byte[] obj)` (`int`): Get Hash Code method.

---

## File: WDBXEditor\Archives\CASC\Misc\Extensions.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: Extensions
  **Description**: Extensions type definition.

  **Methods**:
  * `ToHexString(byte[] bytes)` (`string`): To Hex String method.
  * `Read(Stream stream, int count)` (`byte[]`): Read method.
  * `GetData(string url)` (`byte[]`): Get Data method.
  * `GetStream(string url)` (`Stream`): Get Stream method.
  * `GetBufferedReader(string url)` (`Stream`): Get Buffered Reader method.
  * `GetString(string url)` (`string`): Get String method.
  * `ComputeHash(byte[] data)` (`byte[]`): Compute Hash method.
  * `ComputeHash(Stream stream)` (`byte[]`): Compute Hash method.
  * `Decrypt(byte[] ciphertext, byte[] key)` (`byte[]`): Decrypt method.
  * `Decompress(byte[] compressed)` (`byte[]`): Decompress method.
  * `ReadUInt32(byte[] data, int offset)` (`uint`): Read U Int32 method.
  * `ReadUInt64(byte[] data, int offset)` (`ulong`): Read U Int64 method.
  * `GetContentHash(Stream stream)` (`byte[]`): Get Content Hash method.
  * `GetMD5Hash(string input)` (`string`): Get Md5 Hash method.
  * `GetMD5Hash(byte[] input)` (`string`): Get Md5 Hash method.
  * `GetMD5Hash(Stream input)` (`string`): Get Md5 Hash method.
  * `ToByteArray(string hex)` (`byte[]`): To Byte Array method.

---

## File: WDBXEditor\Archives\CASC\Misc\Lookup3.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: Lookup3
  **Description**: Lookup3 type definition.

  **Methods**:
  * `hash(byte[] k, int offset, int length, uint initval)` (`uint`): Hash method.
  * `hash(string k, uint initval)` (`uint`): Hash method.
  * `hash(byte[] k, uint initval)` (`uint`): Hash method.

---

## File: WDBXEditor\Archives\CASC\Structures\BLTEChunk.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: BLTEChunk
  **Description**: BLTE Chunk type definition.

  **Properties**:
  * `CompSize` (`int`): Comp Size property.
  * `DecompSize` (`int`): Decomp Size property.
  * `Hash` (`byte[]`): Hash property.
  * `Flags` (`byte`): Flags property.

  **Methods**:
  * `BLTEChunk(Stream stream)` (`void`): BLTE Chunk method.

---

## File: WDBXEditor\Archives\CASC\Structures\BLTEEntry.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: BLTEEntry
  **Description**: BLTE Entry type definition.

  **Properties**:
  * `NumChunks` (`byte`): Num Chunks property.
  * `Unk` (`byte[3]`): Unk property.
  * `NumBytes` (`int`): Num Bytes property.
  * `Checksum` (`uint`): Checksum property.
  * `Chunks` (`BLTEChunk[]`): Chunks property.

  **Methods**:
  * `BLTEEntry(byte[] data)` (`void`): BLTE Entry method.
  * `GetData()` (`byte[]`): Get Data method.

---

## File: WDBXEditor\Archives\CASC\Structures\EncodingEntry.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: EncodingEntry
  **Description**: Encoding Entry type definition.

  **Properties**:
  * `Key` (`byte[]`): Key property.
  * `Size` (`int`): Size property.

  **Methods**:
  * `EncodingEntry(byte[] key, int size)` (`void`): Encoding Entry method.

---

## File: WDBXEditor\Archives\CASC\Structures\IndexEntry.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: IndexEntry
  **Description**: Index Entry type definition.

  **Properties**:
  * `Hash` (`byte[]`): Hash property.
  * `Size` (`uint`): Size property.
  * `Offset` (`uint`): Offset property.
  * `Index` (`byte`): Index property.

---

## File: WDBXEditor\Archives\CASC\Structures\RootEntry.cs
**General Description**: This file is related to handling CASC archives, likely for reading or managing game data files.

### Class: RootEntry
  **Description**: Root Entry type definition.

  **Properties**:
  * `Locale` (`LocaleFlags`): Locale property.
  * `ContentHash` (`byte[]`): Content Hash property.
  * `Hash` (`byte[]`): Hash property.

  **Methods**:
  * `RootEntry(byte[] contentHash, byte[] hash, LocaleFlags locale)` (`void`): Root Entry method.

---

## File: WDBXEditor\Archives\MPQ\MpqArchive.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: MpqArchive
  **Description**: Mpq Archive type definition.

  **Properties**:
  * `IsOpened` (`bool`): Is Opened property.
  * `IsPatched` (`bool`): Is Patched property.
  * `FileName` (`string`): File Name property.
  * `PatchedFiles` (`int`): Patched Files property.
  * `OpenFileFlags` (`SFileOpenArchiveFlags`): Open File Flags property.
  * `Compacting` (`MpqArchiveCompactingEventHandler`): Compacting property.

  **Methods**:
  * `MpqArchive(string fileName, SFileOpenArchiveFlags flags)` (`void`): Mpq Archive method.
  * `MpqArchive(string fileName)` (`void`): Mpq Archive method.
  * `Dispose()` (`void`): Dispose method.
  * `Compact()` (`void`): Compact method.
  * `Patch(string patchMpqName)` (`void`): Patch method.
  * `Patch(MpqArchive patchArchive)` (`void`): Patch method.
  * `RemovePatch(string patchMpqName)` (`void`): Remove Patch method.
  * `RemovePatch(MpqArchive patchArchive)` (`void`): Remove Patch method.
  * `AddFile(string sourceFileName, string archiveFileName)` (`void`): Add File method.
  * `AddFile(string sourceFileName, string archiveFileName, MpqCompressionType compressionType, bool autoAdjust)` (`void`): Add File method.
  * `AddFile(byte[] sourceFile, string archiveFileName, MpqCompressionType compressionType, bool autoAdjust)` (`void`): Add File method.
  * `ExtractFile(string archiveFileName, string destinationFileName)` (`void`): Extract File method.
  * `RemoveFile(string fileName)` (`void`): Remove File method.
  * `HasFile(string fileName)` (`bool`): Has File method.
  * `OpenFile(string fileName)` (`MpqFileStream`): Open File method.
  * `GetFileInfo(string fileName)` (`SFileInfo`): Get File Info method.
  * `ListFiles()` (`List<SFileInfo>`): List Files method.

### Delegate: MpqArchiveCompactingEventHandler
  **Description**: Mpq Archive Compacting Event Handler type definition.

### Class: MpqArchiveCompactingEventArgs
  **Description**: Mpq Archive Compacting Event Args type definition.

  **Properties**:
  * `BytesProcessed` (`int`): Bytes Processed property.
  * `BytesTotal` (`int`): Bytes Total property.

  **Methods**:
  * `MpqArchiveCompactingEventArgs(int bytesProcessed, int bytesTotal)` (`void`): Mpq Archive Compacting Event Args method.

### Enum: MpqCompressionType
  **Description**: Mpq Compression Type type definition.

  **Members**:
  * `None`: None member.
  * `Huffman`: Huffman member.
  * `ZLib`: Z Lib member.
  * `PKLib`: Pk Lib member.
  * `BZip2`: B Zip2 member.
  * `LZMA`: Lzma member.
  * `Sparse`: Sparse member.
  * `ADPCM`: Adpcm member.
  * `Wav`: Wav member.
  * `Unk1`: Unk1 member.
  * `Unk2`: Unk2 member.
  * `Unk3`: Unk3 member.
  * `Unk4`: Unk4 member.
  * `Unk5`: Unk5 member.
  * `Unk6`: Unk6 member.
  * `Unk7`: Unk7 member.
  * `Unk8`: Unk8 member.
  * `Unk9`: Unk9 member.
  * `Unk10`: Unk10 member.
  * `Unk11`: Unk11 member.
  * `Unk12`: Unk12 member.
  * `Unk13`: Unk13 member.
  * `Unk14`: Unk14 member.
  * `Unk15`: Unk15 member.

---

## File: WDBXEditor\Archives\MPQ\MpqArchiveCompactingEventArgs.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

---

## File: WDBXEditor\Archives\MPQ\MpqFileStream.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: MpqFileStream
  **Description**: Mpq File Stream type definition.

  **Properties**:
  * `CanRead` (`bool`): Can Read property.
  * `CanSeek` (`bool`): Can Seek property.
  * `CanWrite` (`bool`): Can Write property.
  * `Length` (`long`): Length property.
  * `Position` (`long`): Position property.

  **Methods**:
  * `MpqFileStream(MpqArchive archive, string fileName)` (`void`): Mpq File Stream method.
  * `Flush()` (`void`): Flush method.
  * `Read(byte[] buffer, int offset, int count)` (`int`): Read method.
  * `Seek(long offset, SeekOrigin origin)` (`long`): Seek method.
  * `SetLength(long value)` (`void`): Set Length method.
  * `Write(byte[] buffer, int offset, int count)` (`void`): Write method.
  * `Dispose(bool disposing)` (`void`): Dispose method.

---

## File: WDBXEditor\Archives\MPQ\Native\Callbacks.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: Callbacks
  **Description**: Callbacks type definition.

---

## File: WDBXEditor\Archives\MPQ\Native\MpqArchiveSafeHandle.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: MpqArchiveSafeHandle
  **Description**: Mpq Archive Safe Handle type definition.

  **Properties**:
  * `IsInvalid` (`bool`): Is Invalid property.

  **Methods**:
  * `ReleaseHandle()` (`bool`): Release Handle method.

---

## File: WDBXEditor\Archives\MPQ\Native\MpqFileSafeHandle.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: MpqFileSafeHandle
  **Description**: Mpq File Safe Handle type definition.

  **Properties**:
  * `IsInvalid` (`bool`): Is Invalid property.

  **Methods**:
  * `ReleaseHandle()` (`bool`): Release Handle method.

---

## File: WDBXEditor\Archives\MPQ\Native\NativeMethods.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: NativeMethods
  **Description**: Native Methods type definition.

  **Methods**:
  * `SFileOpenArchive(string lpMpqName, int dwPriority, SFileOpenArchiveFlags dwFlags, out MpqArchiveSafeHandle phMpq)` (`bool`): S File Open Archive method.
  * `SFileCloseArchive(IntPtr hMpq)` (`bool`): S File Close Archive method.
  * `SFileCompactArchive(MpqArchiveSafeHandle hMpq, string szArchiveName, IntPtr lpfnCompactCallback, IntPtr lpUserData)` (`bool`): S File Compact Archive method.
  * `SFileOpenPatchArchive(MpqArchiveSafeHandle hMpq, string szPatchMpqName, string szPatchPath, int dwFlags)` (`bool`): S File Open Patch Archive method.
  * `SFileRemovePatchArchive(MpqArchiveSafeHandle hMpq, string szPatchMpqName)` (`bool`): S File Remove Patch Archive method.
  * `SFileAddFile(MpqArchiveSafeHandle hMpq, string szFileName, string szArchivedName, MpqCompressionType dwFlags)` (`bool`): S File Add File method.
  * `SFileAddFileEx(MpqArchiveSafeHandle hMpq, string szFileName, string szArchivedName, MpqCompressionType dwFlags, IntPtr lpfnAddFileCallback, IntPtr lpUserData)` (`bool`): S File Add File Ex method.
  * `SFileAddWave(MpqArchiveSafeHandle hMpq, string szFileName, string szArchivedName, MpqCompressionType dwFlags, int dwQuality)` (`bool`): S File Add Wave method.
  * `SFileRemoveFile(MpqArchiveSafeHandle hMpq, string szFileName)` (`bool`): S File Remove File method.
  * `SFileExtractFile(MpqArchiveSafeHandle hMpq, string szExistingFileName, string szNewFileName, int dwFlags)` (`bool`): S File Extract File method.
  * `SFileHasFile(MpqArchiveSafeHandle hMpq, string szFileName)` (`bool`): S File Has File method.
  * `SFileOpenFile(MpqArchiveSafeHandle hMpq, string szFileName, int dwUnknown, out MpqFileSafeHandle phFile)` (`bool`): S File Open File method.
  * `SFileGetFileSize(MpqFileSafeHandle hFile, out int lpFileSizeHigh)` (`int`): S File Get File Size method.
  * `SFileSetFilePointer(MpqFileSafeHandle hFile, int lFilePos, out int lpcbFilePosHigh, SeekOrigin dwMethod)` (`int`): S File Set File Pointer method.
  * `SFileReadFile(MpqFileSafeHandle hFile, [Out] byte[] lpBuffer, int dwToRead, out int lpdwBytesRead, IntPtr lpOverlapped)` (`bool`): S File Read File method.
  * `SFileCloseFile(IntPtr hFile)` (`bool`): S File Close File method.
  * `SFileGetFileInfo(MpqArchiveSafeHandle hMpq, string szFileName, SFileInfoClass dwInfoType)` (`int`): S File Get File Info method.
  * `SFileFindFirstFile(MpqArchiveSafeHandle hMpq, string szMask, out SFileInfo lpFindFileData, string szListFile)` (`IntPtr`): S File Find First File method.
  * `SFileFindNextFile(IntPtr hFind, out SFileInfo lpFindFileData)` (`bool`): S File Find Next File method.
  * `SFileFindClose(IntPtr hFind)` (`bool`): S File Find Close method.
  * `SFileOpenArchive(string szMpqName, int dwPriority, int dwFlags, out MpqArchiveSafeHandle phMpq)` (`bool`): S File Open Archive method.
  * `GetLastError()` (`int`): Get Last Error method.

### Struct: SFileInfo
  **Description**: S File Info type definition.

  **Properties**:
  * `FileName` (`string`): File Name property.
  * `CompressedSize` (`int`): Compressed Size property.
  * `FileSize` (`int`): File Size property.
  * `Flags` (`int`): Flags property.
  * `FileTime` (`int`): File Time property.
  * `LcLocale` (`int`): Lc Locale property.
  * `Platform` (`int`): Platform property.

---

## File: WDBXEditor\Archives\MPQ\Native\SFileInfoClass.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Enum: SFileInfoClass
  **Description**: S File Info Class type definition.

  **Members**:
  * `FileInfoPatchArchiveName`: File Info Patch Archive Name member.
  * `FileInfoPatchFileName`: File Info Patch File Name member.
  * `FileInfoStreamFlags`: File Info Stream Flags member.
  * `FileInfoHashIndex`: File Info Hash Index member.
  * `FileInfoNumBlocks`: File Info Num Blocks member.
  * `FileInfoCompressionRatio`: File Info Compression Ratio member.
  * `FileInfoFlags`: File Info Flags member.
  * `FileInfoFileSize`: File Info File Size member.
  * `FileInfoCompressedSize`: File Info Compressed Size member.
  * `FileInfoFileTime`: File Info File Time member.
  * `FileInfoLocale`: File Info Locale member.
  * `FileInfoCRC32`: File Info Cr C32 member.
  * `FileInfoMd5`: File Info Md5 member.
  * `MaxFileInfo`: Max File Info member.

---

## File: WDBXEditor\Archives\MPQ\Native\SFileOpenArchiveFlags.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Enum: SFileOpenArchiveFlags
  **Description**: S File Open Archive Flags type definition.

  **Members**:
  * `None`: None member.
  * `AccessRead`: Access Read member.
  * `AccessWrite`: Access Write member.
  * `AccessReadWrite`: Access Read Write member.
  * `CreateNew`: Create New member.
  * `CreateAlways`: Create Always member.
  * `OpenExisting`: Open Existing member.
  * `OpenAlways`: Open Always member.
  * `ShareRead`: Share Read member.
  * `ShareWrite`: Share Write member.
  * `ShareDelete`: Share Delete member.
  * `ShareExclusive`: Share Exclusive member.
  * `ValidateCrc`: Validate Crc member.
  * `ValidateMd5`: Validate Md5 member.
  * `NoBlock`: No Block member.
  * `NoListFile`: No List File member.
  * `NoAttributes`: No Attributes member.
  * `NoHeaderCrc`: No Header Crc member.
  * `ForceV1`: Force V1 member.
  * `CheckSectorCrc`: Check Sector Crc member.

---

## File: WDBXEditor\Archives\MPQ\Native\Win32Methods.cs
**General Description**: This file is related to handling MPQ archives, likely for reading or managing game data files.

### Class: Win32Methods
  **Description**: Win32 Methods type definition.

  **Methods**:
  * `CreateFile(string lpFileName, FileAccess dwDesiredAccess, FileShare dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)` (`IntPtr`): Create File method.
  * `CloseHandle(IntPtr hObject)` (`bool`): Close Handle method.
  * `GetFileSize(IntPtr hFile, out int lpFileSizeHigh)` (`int`): Get File Size method.
  * `SetFilePointer(IntPtr hFile, int lDistanceToMove, out int lpDistanceToMoveHigh, int dwMoveMethod)` (`int`): Set File Pointer method.
  * `ReadFile(IntPtr hFile, [Out] byte[] lpBuffer, int nNumberOfBytesToRead, out int lpNumberOfBytesRead, IntPtr lpOverlapped)` (`bool`): Read File method.
  * `WriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, out int lpNumberOfBytesWritten, IntPtr lpOverlapped)` (`bool`): Write File method.

---

## File: WDBXEditor\Common\AutoProgressBar.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: AutoProgressBar
  **Description**: Auto Progress Bar type definition.

  **Properties**:
  * `Max` (`int`): Max property.
  * `Value` (`int`): Value property.

  **Methods**:
  * `AutoProgressBar(object sender)` (`void`): Auto Progress Bar method.
  * `Step()` (`void`): Step method.
  * `SetMax(int max)` (`void`): Set Max method.
  * `Close()` (`void`): Close method.

---

## File: WDBXEditor\Common\BufferedListBox.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: BufferedListBox
  **Description**: Buffered List Box type definition.

  **Methods**:
  * `BufferedListBox()` (`void`): Buffered List Box method.
  * `BeginUpdate()` (`void`): Begin Update method.
  * `EndUpdate()` (`void`): End Update method.

---

## File: WDBXEditor\Common\ColourWheel.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: ColourWheel
  **Description**: Colour Wheel type definition.

  **Properties**:
  * `SelectedColour` (`Color`): Selected Colour property.

  **Methods**:
  * `ColourWheel()` (`void`): Colour Wheel method.
  * `SetColour(Color colour)` (`void`): Set Colour method.

---

## File: WDBXEditor\Common\Constants.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: Constants
  **Description**: Constants type definition.

  **Properties**:
  * `WoWRoot` (`string`): Wo W Root property.
  * `DefinitionVersion` (`string`): Definition Version property.
  * `DefinitionUpdateUrl` (`string`): Definition Update Url property.
  * `UpdateUrl` (`string`): Update Url property.
  * `TempFolder` (`string`): Temp Folder property.
  * `SettingsFile` (`string`): Settings File property.

---

## File: WDBXEditor\Common\DropdownCheckList.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: DropdownCheckList
  **Description**: Dropdown Check List type definition.

  **Properties**:
  * `Items` (`IEnumerable<object>`): Items property.
  * `CheckedItems` (`List<string>`): Checked Items property.
  * `Value` (`object`): Value property.
  * `TextChanged` (`EventHandler`): Text Changed property.

  **Methods**:
  * `DropdownCheckList()` (`void`): Dropdown Check List method.
  * `DropdownCheckList(IWin32Window owner)` (`void`): Dropdown Check List method.

---

## File: WDBXEditor\Common\DropdownCheckList.Designer.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application. This is a designer-generated file, typically containing UI component initialization code.

### Class: DropdownCheckList
  **Description**: Dropdown Check List type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Common\Extensions.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: Extensions
  **Description**: Extensions type definition.

  **Methods**:
  * `GetColumnValue<T>(DataRow row, string column)` (`T`): Get Column Value method.
  * `ToByteArray(string hex)` (`byte[]`): To Byte Array method.
  * `ToByte(string hex)` (`byte`): To Byte method.
  * `ToInt(string hex)` (`int`): To Int method.
  * `ToUInt(string hex)` (`uint`): To U Int method.
  * `ToLong(string hex)` (`long`): To Long method.
  * `ToULong(string hex)` (`ulong`): To U Long method.
  * `ToHexString(byte[] bytes, string format)` (`string`): To Hex String method.
  * `ToHexString(byte[] bytes)` (`string`): To Hex String method.
  * `ToHexString(object val)` (`string`): To Hex String method.
  * `ToGuid(byte[] bytes)` (`Guid`): To Guid method.
  * `Between(string text, string left, string right)` (`string`): Between method.
  * `Split(string str, string splitter, bool removeEmptyEntries)` (`string[]`): Split method.
  * `Replace(string value, string oldval, string newval, bool ignorecase)` (`string`): Replace method.
  * `Replace(string value, string oldval, string newval)` (`string`): Replace method.
  * `ReadBytes(this Stream stream, int length)` (`byte[]`): Read Bytes method.
  * `Reverse(byte[] array)` (`byte[]`): Reverse method.
  * `SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)` (`void`): Set Control Property Thread Safe method.
  * `SetText(ToolStripItem item, string text)` (`void`): Set Text method.
  * `SetVisibility(ToolStripItem item, bool visible)` (`void`): Set Visibility method.
  * `SetProgressBarValue(ToolStripProgressBar item, int value)` (`void`): Set Progress Bar Value method.
  * `SetProgressBarMax(ToolStripProgressBar item, int value)` (`void`): Set Progress Bar Max method.
  * `ToFriendlyName(string camelCase)` (`string`): To Friendly Name method.
  * `ParseUrlParams(string url)` (`Dictionary<string, string>`): Parse Url Params method.
  * `GetHotfix(DBReader dbc, string filename)` (`DBReader`): Get Hotfix method.

---

## File: WDBXEditor\Common\FloatUtil.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: FloatUtil
  **Description**: Float Util type definition.

  **Methods**:
  * `GetBits(float f)` (`uint`): Get Bits method.
  * `ToFloat(uint u)` (`float`): To Float method.

---

## File: WDBXEditor\Common\FormHandler.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: FormHandler
  **Description**: Form Handler type definition.

  **Properties**:
  * `DBCs` (`Dictionary<string, DBReader>`): Db Cs property.
  * `OpenedFiles` (`Dictionary<string, string>`): Opened Files property.
  * `SelectedColumnName` (`string`): Selected Column Name property.
  * `SelectedCellValue` (`object`): Selected Cell Value property.
  * `SelectedCellRow` (`DataRow`): Selected Cell Row property.
  * `SelectedCellIndex` (`int`): Selected Cell Index property.
  * `IsSaving` (`bool`): Is Saving property.
  * `MainForm` (`Main`): Main Form property.
  * `Save()` (`bool`): Save method.

  **Methods**:
  * `FormHandler()` (`void`): Form Handler method.
  * `OpenDB(string fileName, string definition)` (`DBReader`): Open Db method.
  * `OpenDB(string fileName, DBReader basedbc)` (`DBReader`): Open Db method.
  * `OpenDB(string fileName, int build, bool hotfixes)` (`DBReader`): Open Db method.
  * `OpenFile(string fileName)` (`DBReader`): Open File method.
  * `LoadDefinition()` (`void`): Load Definition method.
  * `LoadDefinition(string filename)` (`void`): Load Definition method.
  * `ReloadDefinition(string filename)` (`void`): Reload Definition method.
  * `AddDBC(DBReader dbc, bool override)` (`void`): Add Dbc method.
  * `RemoveDBC(DBReader dbc)` (`void`): Remove Dbc method.
  * `Clear()` (`void`): Clear method.
  * `NewFile(string fileName, string definition)` (`DBReader`): New File method.
  * `GetSaveFileName(string title, string filter, string filename)` (`string`): Get Save File Name method.
  * `GetOpenFileName(string title, string filter, string folder)` (`string`): Get Open File Name method.
  * `GetSaveFolderPath()` (`string`): Get Save Folder Path method.
  * `GetHotfixes(DBReader reader)` (`DBReader`): Get Hotfixes method.
  * `ImportCSV(DBReader dbc, string filename, bool header, bool update, bool fixids)` (`bool`): Import CSV method.
  * `ExportCSV(DBReader dbc, string filename, bool header, bool hex)` (`void`): Export CSV method.
  * `ImportSQL(DBReader dbc, string table, string columns, string constr)` (`void`): Import Sql method.
  * `ExportSQL(DBReader dbc, string table, string columns, string constr, string filepath)` (`void`): Export Sql method.
  * `ExportMPQ(DBReader dbc, string filename)` (`void`): Export Mpq method.
  * `UpdateBuildInfo(int build)` (`void`): Update Build Info method.
  * `UpdateTitle()` (`void`): Update Title method.
  * `ShowEditDefinition()` (`void`): Show Edit Definition method.
  * `ShowError(string error, Exception ex)` (`void`): Show Error method.
  * `ShowInfo(string info)` (`void`): Show Info method.
  * `ShowWarning(string info)` (`void`): Show Warning method.
  * `ShowHotfix(DBReader dbc)` (`void`): Show Hotfix method.
  * `ShowMPQ()` (`void`): Show Mpq method.
  * `ShowSQL()` (`void`): Show Sql method.
  * `ShowLog(string text)` (`void`): Show Log method.
  * `ShowCSV(DBReader dbc)` (`void`): Show Csv method.
  * `ShowWotLKItemFix(DBReader dbc)` (`void`): Show Wot Lk Item Fix method.
  * `ShowLegionParser()` (`void`): Show Legion Parser method.
  * `ShowColourPicker(DataRow row, string column)` (`void`): Show Colour Picker method.
  * `InputBox(string title, string prompt)` (`string`): Input Box method.
  * `GetPlayerLocation()` (`PointF`): Get Player Location method.
  * `SelectMessageBox(string title, string prompt, string[] options)` (`string`): Select Message Box method.
  * `GetBuildFromClient()` (`int`): Get Build From Client method.

---

## File: WDBXEditor\Common\GithubReleaseModel.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: GithubReleaseModel
  **Description**: Github Release Model type definition.

  **Properties**:
  * `Url` (`string`): Url property.
  * `AssetsUrl` (`string`): Assets Url property.
  * `UploadUrl` (`string`): Upload Url property.
  * `HtmlUrl` (`string`): Html Url property.
  * `Id` (`int`): Id property.
  * `TagName` (`string`): Tag Name property.
  * `TargetCommitish` (`string`): Target Commitish property.
  * `Name` (`string`): Name property.
  * `Draft` (`bool`): Draft property.
  * `Prerelease` (`bool`): Prerelease property.
  * `CreatedAt` (`DateTime`): Created At property.
  * `PublishedAt` (`DateTime`): Published At property.
  * `Assets` (`Asset[]`): Assets property.
  * `TarballUrl` (`string`): Tarball Url property.
  * `ZipballUrl` (`string`): Zipball Url property.
  * `Body` (`string`): Body property.
  * `LatestVersion` (`Version`): Latest Version property.

  **Methods**:
  * `CompareTo(object obj)` (`int`): Compare To method.

### Class: Asset
  **Description**: Asset type definition.

  **Properties**:
  * `Url` (`string`): Url property.
  * `Id` (`int`): Id property.
  * `Name` (`string`): Name property.
  * `Label` (`object`): Label property.
  * `ContentType` (`string`): Content Type property.
  * `State` (`string`): State property.
  * `Size` (`int`): Size property.
  * `DownloadCount` (`int`): Download Count property.
  * `CreatedAt` (`DateTime`): Created At property.
  * `UpdatedAt` (`DateTime`): Updated At property.
  * `BrowserDownloadUrl` (`string`): Browser Download Url property.

---

## File: WDBXEditor\Common\ORowComparer.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: ORowComparer
  **Description**: O Row Comparer type definition.

  **Methods**:
  * `Compare(object x, object y)` (`int`): Compare method.

---

## File: WDBXEditor\ConsoleHandler\ConsoleCommands.cs
**General Description**: This file is part of the console command handling system, processing command-line arguments.

### Class: ConsoleCommands
  **Description**: Console Commands type definition.

  **Methods**:
  * `RegisterCommands()` (`void`): Register Commands method.
  * `Help(Dictionary<string, string> args)` (`void`): Help method.
  * `Import(Dictionary<string, string> args)` (`void`): Import method.
  * `Export(Dictionary<string, string> args)` (`void`): Export method.
  * `New(Dictionary<string, string> args)` (`void`): New method.

---

## File: WDBXEditor\ConsoleHandler\ConsoleManager.cs
**General Description**: This file is part of the console command handling system, processing command-line arguments.

### Class: ConsoleManager
  **Description**: Console Manager type definition.

  **Properties**:
  * `Handler` (`FormHandler`): Handler property.

  **Methods**:
  * `ConsoleManager()` (`void`): Console Manager method.
  * `SetArgs(string[] args)` (`void`): Set Args method.

---

## File: WDBXEditor\EditDefinition.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: EditDefinition
  **Description**: Edit Definition type definition.

  **Properties**:
  * `Definition` (`Definition`): Definition property.

  **Methods**:
  * `EditDefinition()` (`void`): Edit Definition method.
  * `EditDefinition(Definition def)` (`void`): Edit Definition method.
  * `SetData(Definition def)` (`void`): Set Data method.
  * `RefreshList()` (`void`): Refresh List method.
  * `AddDefinition(string name)` (`void`): Add Definition method.
  * `EditDefinition(string name)` (`void`): Edit Definition method.
  * `DeleteDefinition(string name)` (`void`): Delete Definition method.
  * `AddField(string name)` (`void`): Add Field method.
  * `EditField(string name)` (`void`): Edit Field method.
  * `DeleteField(string name)` (`void`): Delete Field method.
  * `AddSection(string name)` (`void`): Add Section method.
  * `EditSection(string name)` (`void`): Edit Section method.
  * `DeleteSection(string name)` (`void`): Delete Section method.

---

## File: WDBXEditor\EditDefinition.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: EditDefinition
  **Description**: Edit Definition type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\ColourConverter.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: ColourConverter
  **Description**: Colour Converter type definition.

  **Properties**:
  * `SelectedColour` (`Color`): Selected Colour property.

  **Methods**:
  * `ColourConverter()` (`void`): Colour Converter method.
  * `ColourConverter(DataRow row, string column)` (`void`): Colour Converter method.
  * `SetColour(Color c)` (`void`): Set Colour method.

---

## File: WDBXEditor\Forms\ColourConverter.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: ColourConverter
  **Description**: Colour Converter type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\ErrorReport.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: ErrorReport
  **Description**: Error Report type definition.

  **Methods**:
  * `ErrorReport()` (`void`): Error Report method.
  * `ErrorReport(Exception ex, string info)` (`void`): Error Report method.

---

## File: WDBXEditor\Forms\ErrorReport.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: ErrorReport
  **Description**: Error Report type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\FindReplace.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: FindReplace
  **Description**: Find Replace type definition.

  **Properties**:
  * `FindText` (`string`): Find Text property.
  * `ReplaceText` (`string`): Replace Text property.
  * `FindMatchCase` (`bool`): Find Match Case property.
  * `FindMatchWholeWord` (`bool`): Find Match Whole Word property.
  * `FindNext` (`bool`): Find Next property.
  * `ReplaceNext` (`bool`): Replace Next property.
  * `ReplaceAll` (`bool`): Replace All property.
  * `FindColumns` (`List<string>`): Find Columns property.

  **Methods**:
  * `FindReplace()` (`void`): Find Replace method.

---

## File: WDBXEditor\Forms\FindReplace.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: FindReplace
  **Description**: Find Replace type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\InputBox.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: InputBox
  **Description**: Input Box type definition.

  **Properties**:
  * `Value` (`string`): Value property.

  **Methods**:
  * `InputBox(string title, string prompt)` (`void`): Input Box method.

---

## File: WDBXEditor\Forms\LegionParser.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: LegionParser
  **Description**: Legion Parser type definition.

  **Methods**:
  * `LegionParser()` (`void`): Legion Parser method.
  * `ParseFile()` (`void`): Parse File method.
  * `ParseDefinition(string filename)` (`void`): Parse Definition method.

---

## File: WDBXEditor\Forms\LegionParser.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: LegionParser
  **Description**: Legion Parser type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\LoadCSV.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: LoadCSV
  **Description**: Load Csv type definition.

  **Properties**:
  * `UseHeader` (`bool`): Use Header property.
  * `Update` (`bool`): Update property.
  * `FixIds` (`bool`): Fix Ids property.

  **Methods**:
  * `LoadCSV()` (`void`): Load Csv method.

---

## File: WDBXEditor\Forms\LoadCSV.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: LoadCSV
  **Description**: Load Csv type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\LoadDefinition.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: LoadDefinition
  **Description**: Load Definition type definition.

  **Properties**:
  * `FileName` (`string`): File Name property.
  * `NewFile` (`bool`): New File property.

  **Methods**:
  * `LoadDefinition()` (`void`): Load Definition method.

---

## File: WDBXEditor\Forms\LoadDefinition.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: LoadDefinition
  **Description**: Load Definition type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\LoadHotfix.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: LoadHotfix
  **Description**: Load Hotfix type definition.

  **Properties**:
  * `LoadHotfixes` (`bool`): Load Hotfixes property.

  **Methods**:
  * `LoadHotfix()` (`void`): Load Hotfix method.

---

## File: WDBXEditor\Forms\LoadHotfix.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: LoadHotfix
  **Description**: Load Hotfix type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\LoadMPQ.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: LoadMPQ
  **Description**: Load Mpq type definition.

  **Properties**:
  * `FileName` (`string`): File Name property.
  * `Build` (`int`): Build property.

  **Methods**:
  * `LoadMPQ()` (`void`): Load Mpq method.

---

## File: WDBXEditor\Forms\LoadMPQ.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: LoadMPQ
  **Description**: Load Mpq type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\LoadSQL.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: LoadSQL
  **Description**: Load Sql type definition.

  **Properties**:
  * `Columns` (`string`): Columns property.
  * `Table` (`string`): Table property.
  * `ConnectionString` (`string`): Connection String property.
  * `FilePath` (`string`): File Path property.

  **Methods**:
  * `LoadSQL()` (`void`): Load Sql method.
  * `TestConnection()` (`void`): Test Connection method.

---

## File: WDBXEditor\Forms\LoadSQL.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: LoadSQL
  **Description**: Load Sql type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\PlayerLocation.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: PlayerLocation
  **Description**: Player Location type definition.

  **Properties**:
  * `PlayerLoc` (`PointF`): Player Loc property.

  **Methods**:
  * `PlayerLocation()` (`void`): Player Location method.
  * `GetPlayerLocation()` (`PointF`): Get Player Location method.

---

## File: WDBXEditor\Forms\PlayerLocation.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: PlayerLocation
  **Description**: Player Location type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\TextEditor.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: TextEditor
  **Description**: Text Editor type definition.

  **Properties**:
  * `TextValue` (`string`): Text Value property.

  **Methods**:
  * `TextEditor()` (`void`): Text Editor method.
  * `TextEditor(string text)` (`void`): Text Editor method.

---

## File: WDBXEditor\Forms\TextEditor.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: TextEditor
  **Description**: Text Editor type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\Forms\WotLKItemFix.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: WotLKItemFix
  **Description**: Wot Lk Item Fix type definition.

  **Properties**:
  * `FixIds` (`List<int>`): Fix Ids property.

  **Methods**:
  * `WotLKItemFix(DBReader dbc)` (`void`): Wot Lk Item Fix method.

---

## File: WDBXEditor\Forms\WotLKItemFix.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: WotLKItemFix
  **Description**: Wot Lk Item Fix type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\InstanceManager.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: InstanceManager
  **Description**: Instance Manager type definition.

  **Methods**:
  * `GetInstance()` (`InstanceManager`): Get Instance method.
  * `IsAlreadyRunning()` (`bool`): Is Already Running method.

---

## File: WDBXEditor\Main.cs
**General Description**: This file defines a Windows Form or a component related to the user interface.

### Class: Main
  **Description**: Main type definition.

  **Methods**:
  * `Main()` (`void`): Main method.
  * `New(bool hotfixes)` (`void`): New method.
  * `New()` (`void`): New method.
  * `SetProgressBar(string text, int max)` (`void`): Set Progress Bar method.
  * `Progress()` (`void`): Progress method.
  * `ShowError(string message, Exception ex)` (`void`): Show Error method.
  * `ShowInfo(string message)` (`void`): Show Info method.
  * `ShowWarning(string message)` (`void`): Show Warning method.
  * `ShowLog(string text)` (`void`): Show Log method.
  * `ShowLoadHotfix()` (`void`): Show Load Hotfix method.
  * `SetStatusBar(string text)` (`void`): Set Status Bar method.
  * `DisableRibbon()` (`void`): Disable Ribbon method.
  * `EnableRibbon()` (`void`): Enable Ribbon method.
  * `UpdateFileMenu()` (`void`): Update File Menu method.
  * `UpdateEditMenu()` (`void`): Update Edit Menu method.
  * `UpdateExportMenu()` (`void`): Update Export Menu method.
  * `UpdateToolsMenu()` (`void`): Update Tools Menu method.
  * `UpdateRibbonTab()` (`void`): Update Ribbon Tab method.
  * `SetTitle()` (`void`): Set Title method.
  * `SetClipboard(object value)` (`void`): Set Clipboard method.
  * `AddHotfix(DBReader dbc)` (`void`): Add Hotfix method.
  * `RemoveHotfix(DBReader dbc)` (`void`): Remove Hotfix method.
  * `OpenMpq()` (`void`): Open Mpq method.
  * `OpenSQL()` (`void`): Open Sql method.
  * `LoadHotfixes(bool loadHotfixes)` (`void`): Load Hotfixes method.
  * `SaveFile()` (`void`): Save File method.
  * `SaveFileAs()` (`void`): Save File As method.
  * `SaveAll()` (`void`): Save All method.
  * `AddRow()` (`void`): Add Row method.
  * `DeleteRow()` (`void`): Delete Row method.
  * `CopyRow()` (`void`): Copy Row method.
  * `PasteRow()` (`void`): Paste Row method.
  * `GoToRow()` (`void`): Go To Row method.
  * `AddColumn()` (`void`): Add Column method.
  * `HideColumn()` (`void`): Hide Column method.
  * `ShowAllColumns()` (`void`): Show All Columns method.
  * `HideEmptyColumns()` (`void`): Hide Empty Columns method.
  * `Undo()` (`void`): Undo method.
  * `Redo()` (`void`): Redo method.
  * `Find()` (`void`): Find method.
  * `Replace()` (`void`): Replace method.
  * `ImportCSV()` (`void`): Import Csv method.
  * `ExportCSV()` (`void`): Export Csv method.
  * `ImportSQL()` (`void`): Import Sql method.
  * `ExportSQL()` (`void`): Export Sql method.
  * `ExportMPQ()` (`void`): Export Mpq method.
  * `DefinitionEditor()` (`void`): Definition Editor method.
  * `WotLKItemFix()` (`void`): Wot Lk Item Fix method.
  * `LegionParser()` (`void`): Legion Parser method.
  * `PlayerLocation()` (`void`): Player Location method.
  * `About()` (`void`): About method.

---

## File: WDBXEditor\Main.Designer.cs
**General Description**: This file defines a Windows Form or a component related to the user interface. This is a designer-generated file, typically containing UI component initialization code.

### Class: Main
  **Description**: Main type definition.

  **Methods**:
  * `Dispose(bool disposing)` (`void`): Dispose method.
  * `InitializeComponent()` (`void`): Initialize Component method.

---

## File: WDBXEditor\NamedPipeManager.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: NamedPipeManager
  **Description**: Named Pipe Manager type definition.

  **Properties**:
  * `DataReceived` (`EventHandler<DataReceivedEventArgs>`): Data Received property.

  **Methods**:
  * `GetInstance()` (`NamedPipeManager`): Get Instance method.
  * `Listen()` (`void`): Listen method.
  * `Stop()` (`void`): Stop method.
  * `SendCommand(string command)` (`void`): Send Command method.

### Class: DataReceivedEventArgs
  **Description**: Data Received Event Args type definition.

  **Properties**:
  * `Data` (`string`): Data property.

  **Methods**:
  * `DataReceivedEventArgs(string data)` (`void`): Data Received Event Args method.

---

## File: WDBXEditor\obj\Debug\.NETFramework,Version=v4.8.AssemblyAttributes.cs
**General Description**: This file is a build artifact and contains assembly attributes for the project.

---

## File: WDBXEditor\Program.cs
**General Description**: This file contains the entry point for the application.

### Class: Program
  **Description**: Program type definition.

  **Methods**:
  * `Main(string[] args)` (`void`): Main method.

---

## File: WDBXEditor\Properties\AssemblyInfo.cs
**General Description**: This file contains project properties, such as assembly information or resources.

---

## File: WDBXEditor\Properties\Resources.Designer.cs
**General Description**: This file contains project properties, such as assembly information or resources.

### Class: Resources
  **Description**: Resources type definition.

  **Properties**:
  * `ResourceManager` (`ResourceManager`): Resource Manager property.
  * `Culture` (`CultureInfo`): Culture property.
  * `AddRow` (`Bitmap`): Add Row property.
  * `DeleteRow` (`Bitmap`): Delete Row property.
  * `Find` (`Bitmap`): Find property.
  * `Replace` (`Bitmap`): Replace property.
  * `Copy` (`Bitmap`): Copy property.
  * `Cut` (`Bitmap`): Cut property.
  * `Paste` (`Bitmap`): Paste property.
  * `EditDefinition` (`Bitmap`): Edit Definition property.
  * `Error` (`Bitmap`): Error property.
  * `Export` (`Bitmap`): Export property.
  * `ExportCSV` (`Bitmap`): Export Csv property.
  * `ExportSQL` (`Bitmap`): Export Sql property.
  * `FilterColumn` (`Bitmap`): Filter Column property.
  * `GoTo` (`Bitmap`): Go To property.
  * `HideColumn` (`Bitmap`): Hide Column property.
  * `HideEmpty` (`Bitmap`): Hide Empty property.
  * `Import` (`Bitmap`): Import property.
  * `ImportCSV` (`Bitmap`): Import Csv property.
  * `ImportSQL` (`Bitmap`): Import Sql property.
  * `Info` (`Bitmap`): Info property.
  * `LegionParser` (`Bitmap`): Legion Parser property.
  * `NewFile` (`Bitmap`): New File property.
  * `OpenFile` (`Bitmap`): Open File property.
  * `PlayerLocation` (`Bitmap`): Player Location property.
  * `Redo` (`Bitmap`): Redo property.
  * `SaveFile` (`Bitmap`): Save File property.
  * `SaveFileAs` (`Bitmap`): Save File As property.
  * `SaveAll` (`Bitmap`): Save All property.
  * `ShowAllColumns` (`Bitmap`): Show All Columns property.
  * `SQL` (`Bitmap`): Sql property.
  * `Undo` (`Bitmap`): Undo property.
  * `Warning` (`Bitmap`): Warning property.
  * `WotLKItemFix` (`Bitmap`): Wot Lk Item Fix property.

  **Methods**:
  * `get_ResourceManager()` (`ResourceManager`): Get Resource Manager method.
  * `set_Culture(CultureInfo value)` (`void`): Set Culture method.
  * `get_AddRow()` (`Bitmap`): Get Add Row method.
  * `get_DeleteRow()` (`Bitmap`): Get Delete Row method.
  * `get_Find()` (`Bitmap`): Get Find method.
  * `get_Replace()` (`Bitmap`): Get Replace method.
  * `get_Copy()` (`Bitmap`): Get Copy method.
  * `get_Cut()` (`Bitmap`): Get Cut method.
  * `get_Paste()` (`Bitmap`): Get Paste method.
  * `get_EditDefinition()` (`Bitmap`): Get Edit Definition method.
  * `get_Error()` (`Bitmap`): Get Error method.
  * `get_Export()` (`Bitmap`): Get Export method.
  * `get_ExportCSV()` (`Bitmap`): Get Export Csv method.
  * `get_ExportSQL()` (`Bitmap`): Get Export Sql method.
  * `get_FilterColumn()` (`Bitmap`): Get Filter Column method.
  * `get_GoTo()` (`Bitmap`): Get Go To method.
  * `get_HideColumn()` (`Bitmap`): Get Hide Column method.
  * `get_HideEmpty()` (`Bitmap`): Get Hide Empty method.
  * `get_Import()` (`Bitmap`): Get Import method.
  * `get_ImportCSV()` (`Bitmap`): Get Import Csv method.
  * `get_ImportSQL()` (`Bitmap`): Get Import Sql method.
  * `get_Info()` (`Bitmap`): Get Info method.
  * `get_LegionParser()` (`Bitmap`): Get Legion Parser method.
  * `get_NewFile()` (`Bitmap`): Get New File method.
  * `get_OpenFile()` (`Bitmap`): Get Open File method.
  * `get_PlayerLocation()` (`Bitmap`): Get Player Location method.
  * `get_Redo()` (`Bitmap`): Get Redo method.
  * `get_SaveFile()` (`Bitmap`): Get Save File method.
  * `get_SaveFileAs()` (`Bitmap`): Get Save File As method.
  * `get_SaveAll()` (`Bitmap`): Get Save All method.
  * `get_ShowAllColumns()` (`Bitmap`): Get Show All Columns method.
  * `get_SQL()` (`Bitmap`): Get Sql method.
  * `get_Undo()` (`Bitmap`): Get Undo method.
  * `get_Warning()` (`Bitmap`): Get Warning method.
  * `get_WotLKItemFix()` (`Bitmap`): Get Wot Lk Item Fix method.

---

## File: WDBXEditor\Properties\Settings.Designer.cs
**General Description**: This file contains project properties, such as assembly information or resources.

### Class: Settings
  **Description**: Settings type definition.

  **Properties**:
  * `Default` (`Settings`): Default property.
  * `AutoSave` (`bool`): Auto Save property.
  * `WoWPath` (`string`): Wo W Path property.
  * `DefaultDefinition` (`string`): Default Definition property.
  * `WindowLocation` (`Point`): Window Location property.
  * `WindowSize` (`Size`): Window Size property.
  * `WindowMaximized` (`bool`): Window Maximized property.
  * `LoadHotfixes` (`bool`): Load Hotfixes property.
  * `SaveHotfixes` (`bool`): Save Hotfixes property.

  **Methods**:
  * `SettingChanging(object sender, SettingChangingEventArgs e)` (`void`): Setting Changing method.
  * `SettingsSaving(object sender, CancelEventArgs e)` (`void`): Settings Saving method.

---

## File: WDBXEditor\Reader\BitStream.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: BitStream
  **Description**: Bit Stream type definition.

  **Properties**:
  * `Position` (`int`): Position property.

  **Methods**:
  * `BitStream(byte[] bytes)` (`void`): Bit Stream method.
  * `SetPosition(int pos)` (`void`): Set Position method.
  * `Read(int bits)` (`ulong`): Read method.
  * `ReadInt32(int bits)` (`int`): Read Int32 method.

---

## File: WDBXEditor\Reader\ColumnStructureEntry.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: ColumnStructureEntry
  **Description**: Column Structure Entry type definition.

  **Properties**:
  * `Type` (`string`): Type property.
  * `Size` (`int`): Size property.
  * `Offset` (`int`): Offset property.
  * `IsSigned` (`bool`): Is Signed property.
  * `IsRelation` (`bool`): Is Relation property.
  * `IsID` (`bool`): Is Id property.
  * `Key` (`string`): Key property.
  * `Name` (`string`): Name property.
  * `MinValue` (`long`): Min Value property.
  * `MaxValue` (`long`): Max Value property.
  * `IsIndex` (`bool`): Is Index property.
  * `IsBitmask` (`bool`): Is Bitmask property.
  * `IsFloats` (`bool`): Is Floats property.

---

## File: WDBXEditor\Reader\DBHeader.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: DBHeader
  **Description**: Db Header type definition.

  **Properties**:
  * `RecordCount` (`int`): Record Count property.
  * `FieldCount` (`int`): Field Count property.
  * `RecordSize` (`int`): Record Size property.
  * `StringTableSize` (`int`): String Table Size property.
  * `TableHash` (`uint`): Table Hash property.
  * `Build` (`int`): Build property.
  * `MinIndex` (`int`): Min Index property.
  * `MaxIndex` (`int`): Max Index property.
  * `Locale` (`uint`): Locale property.
  * `CopyTableSize` (`int`): Copy Table Size property.
  * `Flags` (`ushort`): Flags property.
  * `IdIndex` (`ushort`): Id Index property.
  * `TotalFieldSize` (`ushort`): Total Field Size property.
  * `RelationCount` (`ushort`): Relation Count property.
  * `PageSize` (`ushort`): Page Size property.
  * `SparseTableSize` (`uint`): Sparse Table Size property.
  * `Timestamp` (`uint`): Timestamp property.
  * `NumBlocks` (`uint`): Num Blocks property.
  * `RelationshipDataSize` (`int`): Relationship Data Size property.
  * `OffsetMapOffset` (`int`): Offset Map Offset property.
  * `FieldOffsetMapOffset` (`int`): Field Offset Map Offset property.
  * `CommonDataOffset` (`int`): Common Data Offset property.
  * `PalletDataOffset` (`int`): Pallet Data Offset property.
  * `PalletBlockCount` (`int`): Pallet Block Count property.
  * `ColumnDataOffset` (`int`): Column Data Offset property.
  * `IdPos` (`int`): Id Pos property.
  * `HotfixDataSize` (`int`): Hotfix Data Size property.
  * `Has and ID block` (`bool`): Has And Id Block property.
  * `Is sparse` (`bool`): Is Sparse property.
  * `Is pallet` (`bool`): Is Pallet property.
  * `Has a relationship table` (`bool`): Has A Relationship Table property.
  * `Is hotfix` (`bool`): Is Hotfix property.
  * `Has common data` (`bool`): Has Common Data property.
  * `Has an index table` (`bool`): Has An Index Table property.

  **Methods**:
  * `DBHeader(BinaryReader br, string signature)` (`void`): Db Header method.
  * `SetHeader(string signature)` (`void`): Set Header method.

---

## File: WDBXEditor\Reader\DBReader.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: DBReader
  **Description**: Db Reader type definition.

  **Properties**:
  * `FileName` (`string`): File Name property.
  * `Definition` (`Definition`): Definition property.
  * `Is and ADB` (`bool`): Is And Adb property.
  * `Table` (`DataTable`): Table property.
  * `Header` (`DBHeader`): Header property.
  * `StringTable` (`StringTable`): String Table property.
  * `Build` (`int`): Build property.
  * `Id` (`int`): Id property.

  **Methods**:
  * `DBReader(string fileName, Definition def)` (`void`): Db Reader method.
  * `Save()` (`void`): Save method.
  * `Save(string fileName)` (`void`): Save method.
  * `Load(string fileName, Definition def)` (`void`): Load method.
  * `Load(string fileName)` (`void`): Load method.
  * `Load(Stream stream, Definition def)` (`void`): Load method.
  * `UpdateTable()` (`void`): Update Table method.
  * `Parse()` (`void`): Parse method.
  * `SetDefinition(Definition def)` (`void`): Set Definition method.
  * `RefreshTable()` (`void`): Refresh Table method.
  * `GetDefinition<T>()` (`T`): Get Definition method.

---

## File: WDBXEditor\Reader\DBReaderExtensions.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: DBReaderExtensions
  **Description**: Db Reader Extensions type definition.

  **Methods**:
  * `ReadWDB(DBReader dbc, BinaryReader br)` (`void`): Read Wdb method.
  * `ReadWCH7(DBReader dbc, BinaryReader br)` (`void`): Read Wch7 method.
  * `ReadWCH8(DBReader dbc, BinaryReader br)` (`void`): Read Wch8 method.
  * `ReadWDB2(DBReader dbc, BinaryReader br)` (`void`): Read Wdb2 method.
  * `ReadWDB5(DBReader dbc, BinaryReader br)` (`void`): Read Wdb5 method.
  * `ReadWDB6(DBReader dbc, BinaryReader br)` (`void`): Read Wdb6 method.
  * `ReadWDC1(DBReader dbc, BinaryReader br)` (`void`): Read Wdc1 method.
  * `ReadWDC2(DBReader dbc, BinaryReader br)` (`void`): Read Wdc2 method.
  * `ReadWDC3(DBReader dbc, BinaryReader br)` (`void`): Read Wdc3 method.
  * `ReadWDBC(DBReader dbc, BinaryReader br)` (`void`): Read Wdbc method.
  * `ReadHTFX(DBReader dbc, BinaryReader br)` (`void`): Read Htfx method.
  * `WriteWDB(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdb method.
  * `WriteWCH7(DBReader dbc, BinaryWriter bw)` (`void`): Write Wch7 method.
  * `WriteWCH8(DBReader dbc, BinaryWriter bw)` (`void`): Write Wch8 method.
  * `WriteWDB2(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdb2 method.
  * `WriteWDB5(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdb5 method.
  * `WriteWDB6(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdb6 method.
  * `WriteWDC1(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdc1 method.
  * `WriteWDC2(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdc2 method.
  * `WriteWDC3(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdc3 method.
  * `WriteWDBC(DBReader dbc, BinaryWriter bw)` (`void`): Write Wdbc method.
  * `GetIdIndex(DBReader dbc)` (`int`): Get Id Index method.
  * `GetColumns(DBReader dbc, bool includeid)` (`string[]`): Get Columns method.
  * `GetDefinitionFile(DBReader dbc)` (`string`): Get Definition File method.
  * `GetDefinitionFile(string filename, int build)` (`string`): Get Definition File method.
  * `GetDefinitionFile(string filename)` (`string`): Get Definition File method.

---

## File: WDBXEditor\Reader\FieldStructureEntry.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: FieldStructureEntry
  **Description**: Field Structure Entry type definition.

  **Properties**:
  * `Bits` (`byte`): Bits property.
  * `Offset` (`ushort`): Offset property.

---

## File: WDBXEditor\Reader\FileTypes\HTFX.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: HTFX
  **Description**: Htfx type definition.

---

## File: WDBXEditor\Reader\FileTypes\WCH5.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WCH5
  **Description**: Wch5 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WCH7.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WCH7
  **Description**: Wch7 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WCH8.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WCH8
  **Description**: Wch8 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDB.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDB
  **Description**: Wdb type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDB2.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDB2
  **Description**: Wdb2 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDB5.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDB5
  **Description**: Wdb5 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDB6.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDB6
  **Description**: Wdb6 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDBC.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDBC
  **Description**: Wdbc type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDC1.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDC1
  **Description**: Wdc1 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDC2.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDC2
  **Description**: Wdc2 type definition.

---

## File: WDBXEditor\Reader\FileTypes\WDC3.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: WDC3
  **Description**: Wdc3 type definition.

---

## File: WDBXEditor\Reader\MemoryReader.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: MemoryReader
  **Description**: Memory Reader type definition.

  **Methods**:
  * `GetInstance()` (`MemoryReader`): Get Instance method.
  * `GetPlayerLocation()` (`PointF`): Get Player Location method.
  * `GetClientBuild()` (`int`): Get Client Build method.

---

## File: WDBXEditor\Reader\RelationShipData.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: RelationShipData
  **Description**: Relation Ship Data type definition.

  **Properties**:
  * `MinId` (`int`): Min Id property.
  * `MaxId` (`int`): Max Id property.
  * `NumRows` (`int`): Num Rows property.
  * `Entrys` (`Dictionary<int, int>`): Entrys property.

  **Methods**:
  * `RelationShipData(BinaryReader br)` (`void`): Relation Ship Data method.

---

## File: WDBXEditor\Reader\StringTable.cs
**General Description**: This file is part of the data reading/parsing subsystem, likely for DBC/DB2/WDB files.

### Class: StringTable
  **Description**: String Table type definition.

  **Properties**:
  * `Table` (`Dictionary<int, string>`): Table property.
  * `Size` (`int`): Size property.

  **Methods**:
  * `StringTable()` (`void`): String Table method.
  * `StringTable(BinaryReader br, int stringTableSize)` (`void`): String Table method.
  * `StringTable(byte[] bytes)` (`void`): String Table method.
  * `Add(string s)` (`int`): Add method.
  * `Get(int offset)` (`string`): Get method.
  * `GetBytes()` (`byte[]`): Get Bytes method.

---

## File: WDBXEditor\Storage\Database.cs
**General Description**: This file is related to data storage, definitions, or database interactions.

### Class: Database
  **Description**: Database type definition.

  **Methods**:
  * `CreateConnection(string connectionString)` (`MySqlConnection`): Create Connection method.
  * `LoadData(string connectionString, string table, string columns)` (`DataTable`): Load Data method.
  * `ImportData(string connectionString, string table, DataTable data, bool update)` (`void`): Import Data method.
  * `ExportData(string connectionString, string table, DataTable data)` (`void`): Export Data method.
  * `ExportData(string connectionString, string table, DataTable data, string filepath)` (`void`): Export Data method.

---

## File: WDBXEditor\Storage\DBEntry.cs
**General Description**: This file is related to data storage, definitions, or database interactions.

### Class: DBEntry
  **Description**: Db Entry type definition.

  **Properties**:
  * `Table` (`string`): Table property.
  * `Build` (`int`): Build property.
  * `FileName` (`string`): File Name property.
  * `Definition` (`Definition`): Definition property.

  **Methods**:
  * `DBEntry()` (`void`): Db Entry method.
  * `DBEntry(string table, int build, string fileName, Definition definition)` (`void`): Db Entry method.

---

## File: WDBXEditor\Storage\Definition.cs
**General Description**: This file is related to data storage, definitions, or database interactions.

### Class: Definition
  **Description**: Definition type definition.

  **Properties**:
  * `Name` (`string`): Name property.
  * `FileName` (`string`): File Name property.
  * `Builds` (`List<int>`): Builds property.
  * `Relations` (`List<Relation>`): Relations property.
  * `TableStructure` (`TableStructure`): Table Structure property.

  **Methods**:
  * `Definition()` (`void`): Definition method.
  * `Load(string fileName)` (`Definition`): Load method.
  * `Save(string fileName)` (`void`): Save method.
  * `GetField(int offset, int bits)` (`ColumnStructureEntry`): Get Field method.
  * `UpdateFieldOffsets()` (`void`): Update Field Offsets method.
  * `HasOffsets()` (`bool`): Has Offsets method.

### Class: Relation
  **Description**: Relation type definition.

  **Properties**:
  * `File` (`string`): File property.
  * `LocalField` (`string`): Local Field property.
  * `ForeignField` (`string`): Foreign Field property.

### Class: TableStructure
  **Description**: Table Structure type definition.

  **Properties**:
  * `Fields` (`List<Field>`): Fields property.
  * `SparseFields` (`List<SparseField>`): Sparse Fields property.
  * `Columns` (`List<Column>`): Columns property.
  * `Id` (`string`): Id property.
  * `MinIndex` (`string`): Min Index property.
  * `MaxIndex` (`string`): Max Index property.
  * `Relations` (`string`): Relations property.
  * `Parent` (`string`): Parent property.
  * `Timestamp` (`string`): Timestamp property.
  * `Build` (`string`): Build property.
  * `Offset` (`string`): Offset property.
  * `Size` (`string`): Size property.
  * `Unknown` (`string`): Unknown property.

### Class: Field
  **Description**: Field type definition.

  **Properties**:
  * `Name` (`string`): Name property.
  * `Type` (`string`): Type property.
  * `Size` (`int`): Size property.
  * `IsSigned` (`bool`): Is Signed property.
  * `IsRelation` (`bool`): Is Relation property.
  * `IsID` (`bool`): Is Id property.
  * `ArraySize` (`int`): Array Size property.
  * `Key` (`string`): Key property.
  * `Offset` (`int`): Offset property.
  * `IsIndex` (`bool`): Is Index property.
  * `IsBitmask` (`bool`): Is Bitmask property.
  * `IsFloats` (`bool`): Is Floats property.

### Class: SparseField
  **Description**: Sparse Field type definition.

  **Properties**:
  * `Name` (`string`): Name property.
  * `Type` (`string`): Type property.
  * `Size` (`int`): Size property.
  * `IsSigned` (`bool`): Is Signed property.
  * `IsRelation` (`bool`): Is Relation property.
  * `IsID` (`bool`): Is Id property.
  * `Key` (`string`): Key property.
  * `Offset` (`int`): Offset property.
  * `IsIndex` (`bool`): Is Index property.
  * `IsBitmask` (`bool`): Is Bitmask property.
  * `IsFloats` (`bool`): Is Floats property.

### Class: Column
  **Description**: Column type definition.

  **Properties**:
  * `Name` (`string`): Name property.
  * `Type` (`string`): Type property.
  * `Size` (`int`): Size property.
  * `IsSigned` (`bool`): Is Signed property.
  * `IsRelation` (`bool`): Is Relation property.
  * `IsID` (`bool`): Is Id property.
  * `Key` (`string`): Key property.
  * `Offset` (`int`): Offset property.
  * `IsIndex` (`bool`): Is Index property.
  * `IsBitmask` (`bool`): Is Bitmask property.
  * `IsFloats` (`bool`): Is Floats property.

---

## File: WDBXEditor\UpdateManager.cs
**General Description**: This file contains common utilities, extensions, or helper classes used throughout the application.

### Class: UpdateManager
  **Description**: Update Manager type definition.

  **Properties**:
  * `UpdateCheckCompleted` (`EventHandler`): Update Check Completed property.

  **Methods**:
  * `GetInstance()` (`UpdateManager`): Get Instance method.
  * `CheckForUpdate()` (`void`): Check For Update method.
  * `DownloadAndInstall(Asset asset)` (`void`): Download And Install method.

---
