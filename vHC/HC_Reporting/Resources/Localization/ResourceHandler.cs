using System.Resources;
namespace VeeamHealthCheck
{

class ResourceHandler
{private static ResourceManager m4 = new("VeeamHealthCheck.Resources.Localization.vhcres", typeof(ResourceHandler).Assembly);

public static string GuiAcceptButton = m4.GetString("GuiAcceptButton");
public static string GuiAcceptText = m4.GetString("GuiAcceptText");
public static string GuiImportButton = m4.GetString("GuiImportButton");
public static string GuiImportModeOnly = m4.GetString("GuiImportModeOnly");
public static string GuiInstCaveat1 = m4.GetString("GuiInstCaveat1");
public static string GuiInstCaveat2 = m4.GetString("GuiInstCaveat2");
public static string GuiInstHeader = m4.GetString("GuiInstHeader");
public static string GuiInstLine1 = m4.GetString("GuiInstLine1");
public static string GuiInstLine2 = m4.GetString("GuiInstLine2");
public static string GuiInstLine3 = m4.GetString("GuiInstLine3");
public static string GuiInstLine4 = m4.GetString("GuiInstLine4");
public static string GuiInstLine5 = m4.GetString("GuiInstLine5");
public static string GuiInstLine6 = m4.GetString("GuiInstLine6");
public static string GuiOptionsHeader = m4.GetString("GuiOptionsHeader");
public static string GuiOutPath = m4.GetString("GuiOutPath");
public static string GuiRunButton = m4.GetString("GuiRunButton");
public static string GuiSensData = m4.GetString("GuiSensData");
public static string GuiShowFiles = m4.GetString("GuiShowFiles");
public static string GuiShowHtml = m4.GetString("GuiShowHtml");
public static string GuiTitle = m4.GetString("GuiTitle");
public static string GuiTitleBnR = m4.GetString("GuiTitleBnR");
public static string GuiTitleVB365 = m4.GetString("GuiTitleVB365");
public static string PlHdr0 = m4.GetString("PlHdr0");
public static string PlHdrTT0 = m4.GetString("PlHdrTT0");
public static string PlHdr1 = m4.GetString("PlHdr1");
public static string PlHdrTT1 = m4.GetString("PlHdrTT1");
public static string PlHdr2 = m4.GetString("PlHdr2");
public static string PlHdrTT2 = m4.GetString("PlHdrTT2");
public static string PlHdr3 = m4.GetString("PlHdr3");
public static string PlHdrTT3 = m4.GetString("PlHdrTT3");
public static string PlHdr4 = m4.GetString("PlHdr4");
public static string PlHdrTT4 = m4.GetString("PlHdrTT4");
public static string PlHdr5 = m4.GetString("PlHdr5");
public static string PlHdrTT5 = m4.GetString("PlHdrTT5");
public static string PlHdr6 = m4.GetString("PlHdr6");
public static string PlHdrTT6 = m4.GetString("PlHdrTT6");
public static string PlHdr7 = m4.GetString("PlHdr7");
public static string PlHdrTT7 = m4.GetString("PlHdrTT7");
public static string PlSum1 = m4.GetString("PlSum1");
public static string PlNote1 = m4.GetString("PlNote1");
public static string PlButton = m4.GetString("PlButton");
public static string PlTitle = m4.GetString("PlTitle");
public static string GeneralNotesHeader = m4.GetString("GeneralNotesHeader");
public static string GeneralSummaryHeader = m4.GetString("GeneralSummaryHeader");
public static string HtmlHeader = m4.GetString("HtmlHeader");
public static string HtmlIntroLine1 = m4.GetString("HtmlIntroLine1");
public static string HtmlIntroLine2 = m4.GetString("HtmlIntroLine2");
public static string HtmlIntroLine3Original = m4.GetString("HtmlIntroLine3Original");
public static string HtmlIntroLine3Anon = m4.GetString("HtmlIntroLine3Anon");
public static string HtmlIntroLine4 = m4.GetString("HtmlIntroLine4");
public static string HtmlIntroLine5 = m4.GetString("HtmlIntroLine5");
public static string HtmlIntroLine5vb365 = m4.GetString("HtmlIntroLine5vb365");
public static string NavBkpSrvDeet = m4.GetString("NavBkpSrvDeet");
public static string NavBkpSrvLink = m4.GetString("NavBkpSrvLink");
public static string NavColapse = m4.GetString("NavColapse");
public static string NavHeader = m4.GetString("NavHeader");
public static string NavJobConDeet = m4.GetString("NavJobConDeet");
public static string NavJobConLink = m4.GetString("NavJobConLink");
public static string NavJobInfoDeet = m4.GetString("NavJobInfoDeet");
public static string NavJobInfoLink = m4.GetString("NavJobInfoLink");
public static string NavJobSessSumDeet = m4.GetString("NavJobSessSumDeet");
public static string NavJobSessSumLink = m4.GetString("NavJobSessSumLink");
public static string NavJobSumDeet = m4.GetString("NavJobSumDeet");
public static string NavJobSumLink = m4.GetString("NavJobSumLink");
public static string NavLicInfoDetail = m4.GetString("NavLicInfoDetail");
public static string NavLicInfoLink = m4.GetString("NavLicInfoLink");
public static string NavMissingDeet = m4.GetString("NavMissingDeet");
public static string NavMissingJobLink = m4.GetString("NavMissingJobLink");
public static string NavProtWkldDeet = m4.GetString("NavProtWkldDeet");
public static string NavProtWrkld = m4.GetString("NavProtWrkld");
public static string NavProxyDeet = m4.GetString("NavProxyDeet");
public static string NavProxyInfoLink = m4.GetString("NavProxyInfoLink");
public static string NavRegKeyDeet = m4.GetString("NavRegKeyDeet");
public static string NavRegKeyLink = m4.GetString("NavRegKeyLink");
public static string NavRepoDeet = m4.GetString("NavRepoDeet");
public static string NavRepoInfoLink = m4.GetString("NavRepoInfoLink");
public static string NavSecSumDeet = m4.GetString("NavSecSumDeet");
public static string NavSecSumLink = m4.GetString("NavSecSumLink");
public static string NavSobrDeet = m4.GetString("NavSobrDeet");
public static string NavSobrExtDeet = m4.GetString("NavSobrExtDeet");
public static string NavSobrExtLink = m4.GetString("NavSobrExtLink");
public static string NavSobrInfoLink = m4.GetString("NavSobrInfoLink");
public static string NavSrvInfoDeet = m4.GetString("NavSrvInfoDeet");
public static string NavSrvInfoLink = m4.GetString("NavSrvInfoLink");
public static string NavSrvSumDeet = m4.GetString("NavSrvSumDeet");
public static string NavSrvSumLink = m4.GetString("NavSrvSumLink");
public static string NavTaskConDeet = m4.GetString("NavTaskConDeet");
public static string NavTaskConLink = m4.GetString("NavTaskConLink");
public static string LicCcTT = m4.GetString("LicCcTT");
public static string LicExpTT = m4.GetString("LicExpTT");
public static string LicTblLicTo = m4.GetString("LicTblLicTo");
public static string LicSupExpTT = m4.GetString("LicSupExpTT");
public static string LicTableHeader = m4.GetString("LicTableHeader");
public static string LicTblCc = m4.GetString("LicTblCc");
public static string LicTblEdition = m4.GetString("LicTblEdition");
public static string LicTblExpDate = m4.GetString("LicTblExpDate");
public static string LicTblLicInst = m4.GetString("LicTblLicInst");
public static string LicTblLicNas = m4.GetString("LicTblLicNas");
public static string LicTblLicSock = m4.GetString("LicTblLicSock");
public static string LicTblNewInst = m4.GetString("LicTblNewInst");
public static string LicTblRentInst = m4.GetString("LicTblRentInst");
public static string LicTblStatus = m4.GetString("LicTblStatus");
public static string LicTblSupExpDate = m4.GetString("LicTblSupExpDate");
public static string LicTblType = m4.GetString("LicTblType");
public static string LicTblUsedInst = m4.GetString("LicTblUsedInst");
public static string LicTblUsedNas = m4.GetString("LicTblUsedNas");
public static string LicTblUsedSock = m4.GetString("LicTblUsedSock");
public static string LtEdTT = m4.GetString("LtEdTT");
public static string LtInstLicTT = m4.GetString("LtInstLicTT");
public static string LtInstNewTT = m4.GetString("LtInstNewTT");
public static string LtInstRentalTT = m4.GetString("LtInstRentalTT");
public static string LtInstUsedTT = m4.GetString("LtInstUsedTT");
public static string LtNasLicTT = m4.GetString("LtNasLicTT");
public static string LtNasUsedTT = m4.GetString("LtNasUsedTT");
public static string LtSocLicTT = m4.GetString("LtSocLicTT");
public static string LtSocUsedTT = m4.GetString("LtSocUsedTT");
public static string LtStatusTT = m4.GetString("LtStatusTT");
public static string LtTypeTT = m4.GetString("LtTypeTT");
public static string NpButton = m4.GetString("NpButton");
public static string NpSum1 = m4.GetString("NpSum1");
public static string NpTitle = m4.GetString("NpTitle");
public static string SSHdr0 = m4.GetString("SSHdr0");
public static string SSHdrTT0 = m4.GetString("SSHdrTT0");
public static string SSHdr1 = m4.GetString("SSHdr1");
public static string SSHdrTT1 = m4.GetString("SSHdrTT1");
public static string SSHdr2 = m4.GetString("SSHdr2");
public static string SSHdrTT2 = m4.GetString("SSHdrTT2");
public static string SSHdr3 = m4.GetString("SSHdr3");
public static string SSHdrTT3 = m4.GetString("SSHdrTT3");
public static string SSSum1 = m4.GetString("SSSum1");
public static string SSSubHdr1 = m4.GetString("SSSubHdr1");
public static string SSSubHdr2 = m4.GetString("SSSubHdr2");
public static string SSSubHdr3 = m4.GetString("SSSubHdr3");
public static string SSSubHdr4 = m4.GetString("SSSubHdr4");
public static string SSNote1 = m4.GetString("SSNote1");
public static string SSNote2 = m4.GetString("SSNote2");
public static string SSNote3 = m4.GetString("SSNote3");
public static string SSNote4 = m4.GetString("SSNote4");
public static string SSButton = m4.GetString("SSButton");
public static string SSTitle = m4.GetString("SSTitle");
public static string MssTitle = m4.GetString("MssTitle");
public static string MssHdr1 = m4.GetString("MssHdr1");
public static string MssHdr2 = m4.GetString("MssHdr2");
public static string MssHdr1TT = m4.GetString("MssHdr1TT");
public static string MssHdr2TT = m4.GetString("MssHdr2TT");
public static string MssSum1 = m4.GetString("MssSum1");
public static string MssButton = m4.GetString("MssButton");
public static string BkpSrvButton = m4.GetString("BkpSrvButton");
public static string BkpSrvNotes1 = m4.GetString("BkpSrvNotes1");
public static string BkpSrvNotes2 = m4.GetString("BkpSrvNotes2");
public static string BkpSrvNotes3 = m4.GetString("BkpSrvNotes3");
public static string BkpSrvNotes4 = m4.GetString("BkpSrvNotes4");
public static string BkpSrvNotes5 = m4.GetString("BkpSrvNotes5");
public static string BkpSrvNotes6 = m4.GetString("BkpSrvNotes6");
public static string BkpSrvSummary1 = m4.GetString("BkpSrvSummary1");
public static string BkpSrvSummary2 = m4.GetString("BkpSrvSummary2");
public static string BkpSrvSummary3 = m4.GetString("BkpSrvSummary3");
public static string BkpSrvSummary4 = m4.GetString("BkpSrvSummary4");
public static string BkpSrvTblCfgEnabled = m4.GetString("BkpSrvTblCfgEnabled");
public static string BkpSrvTblCfgEncrypt = m4.GetString("BkpSrvTblCfgEncrypt");
public static string BkpSrvTblCfgLastRes = m4.GetString("BkpSrvTblCfgLastRes");
public static string BkpSrvTblCore = m4.GetString("BkpSrvTblCore");
public static string BkpSrvTblHead = m4.GetString("BkpSrvTblHead");
public static string BkpSrvTblName = m4.GetString("BkpSrvTblName");
public static string BkpSrvTblProxyRole = m4.GetString("BkpSrvTblProxyRole");
public static string BkpSrvTblRam = m4.GetString("BkpSrvTblRam");
public static string BkpSrvTblRepoRole = m4.GetString("BkpSrvTblRepoRole");
public static string BkpSrvTblSqlCores = m4.GetString("BkpSrvTblSqlCores");
public static string BkpSrvTblSqlEdition = m4.GetString("BkpSrvTblSqlEdition");
public static string BkpSrvTblSqlLocal = m4.GetString("BkpSrvTblSqlLocal");
public static string BkpSrvTblSqlName = m4.GetString("BkpSrvTblSqlName");
public static string BkpSrvTblSqlRam = m4.GetString("BkpSrvTblSqlRam");
public static string BkpSrvTblSqlVersion = m4.GetString("BkpSrvTblSqlVersion");
public static string BkpSrvTblTarget = m4.GetString("BkpSrvTblTarget");
public static string BkpSrvTblVersion = m4.GetString("BkpSrvTblVersion");
public static string BkpSrvTblWanRole = m4.GetString("BkpSrvTblWanRole");
public static string BstCfgEnabledTT = m4.GetString("BstCfgEnabledTT");
public static string BstCfgEncTT = m4.GetString("BstCfgEncTT");
public static string BstCfgLastResTT = m4.GetString("BstCfgLastResTT");
public static string BstCfgTarTT = m4.GetString("BstCfgTarTT");
public static string BstCpuTT = m4.GetString("BstCpuTT");
public static string BstNameTT = m4.GetString("BstNameTT");
public static string BstPrxTT = m4.GetString("BstPrxTT");
public static string BstRamTT = m4.GetString("BstRamTT");
public static string BstRepTT = m4.GetString("BstRepTT");
public static string BstSqlCpuTT = m4.GetString("BstSqlCpuTT");
public static string BstSqlEdTT = m4.GetString("BstSqlEdTT");
public static string BstSqlLocTT = m4.GetString("BstSqlLocTT");
public static string BstSqlNameTT = m4.GetString("BstSqlNameTT");
public static string BstSqlRamTT = m4.GetString("BstSqlRamTT");
public static string BstSqlVerTT = m4.GetString("BstSqlVerTT");
public static string BstVerTT = m4.GetString("BstVerTT");
public static string BstWaTT = m4.GetString("BstWaTT");
public static string SbrTitle = m4.GetString("SbrTitle");
public static string SbrBtn = m4.GetString("SbrBtn");
public static string Sbr0 = m4.GetString("Sbr0");
public static string Sbr0TT = m4.GetString("Sbr0TT");
public static string Sbr1 = m4.GetString("Sbr1");
public static string Sbr1TT = m4.GetString("Sbr1TT");
public static string Sbr2 = m4.GetString("Sbr2");
public static string Sbr2TT = m4.GetString("Sbr2TT");
public static string Sbr3 = m4.GetString("Sbr3");
public static string Sbr3TT = m4.GetString("Sbr3TT");
public static string Sbr4 = m4.GetString("Sbr4");
public static string Sbr4TT = m4.GetString("Sbr4TT");
public static string Sbr5 = m4.GetString("Sbr5");
public static string Sbr5TT = m4.GetString("Sbr5TT");
public static string Sbr6 = m4.GetString("Sbr6");
public static string Sbr6TT = m4.GetString("Sbr6TT");
public static string Sbr7 = m4.GetString("Sbr7");
public static string Sbr7TT = m4.GetString("Sbr7TT");
public static string Sbr8 = m4.GetString("Sbr8");
public static string Sbr8TT = m4.GetString("Sbr8TT");
public static string Sbr9 = m4.GetString("Sbr9");
public static string Sbr9TT = m4.GetString("Sbr9TT");
public static string Sbr10 = m4.GetString("Sbr10");
public static string Sbr10TT = m4.GetString("Sbr10TT");
public static string Sbr11 = m4.GetString("Sbr11");
public static string Sbr11TT = m4.GetString("Sbr11TT");
public static string Sbr12 = m4.GetString("Sbr12");
public static string Sbr12TT = m4.GetString("Sbr12TT");
public static string SbrSum0 = m4.GetString("SbrSum0");
public static string SbrSum1 = m4.GetString("SbrSum1");
public static string SbrNote0 = m4.GetString("SbrNote0");
public static string SbrNote1 = m4.GetString("SbrNote1");
public static string SbrNote2 = m4.GetString("SbrNote2");
public static string SbrNote3 = m4.GetString("SbrNote3");
public static string SbrNote4 = m4.GetString("SbrNote4");
public static string SbrNote5 = m4.GetString("SbrNote5");
public static string SbrNote6 = m4.GetString("SbrNote6");
public static string SbrButton = m4.GetString("SbrButton");
public static string SbrExtTitle = m4.GetString("SbrExtTitle");
public static string SbrExtBtn = m4.GetString("SbrExtBtn");
public static string SbrExt0 = m4.GetString("SbrExt0");
public static string SbrExt0TT = m4.GetString("SbrExt0TT");
public static string SbrExt1 = m4.GetString("SbrExt1");
public static string SbrExt1TT = m4.GetString("SbrExt1TT");
public static string SbrExt2 = m4.GetString("SbrExt2");
public static string SbrExt2TT = m4.GetString("SbrExt2TT");
public static string SbrExt3 = m4.GetString("SbrExt3");
public static string SbrExt3TT = m4.GetString("SbrExt3TT");
public static string SbrExt4 = m4.GetString("SbrExt4");
public static string SbrExt4TT = m4.GetString("SbrExt4TT");
public static string SbrExt5 = m4.GetString("SbrExt5");
public static string SbrExt5TT = m4.GetString("SbrExt5TT");
public static string SbrExt6 = m4.GetString("SbrExt6");
public static string SbrExt6TT = m4.GetString("SbrExt6TT");
public static string SbrExt7 = m4.GetString("SbrExt7");
public static string SbrExt7TT = m4.GetString("SbrExt7TT");
public static string SbrExt8 = m4.GetString("SbrExt8");
public static string SbrExt8TT = m4.GetString("SbrExt8TT");
public static string SbrExt9 = m4.GetString("SbrExt9");
public static string SbrExt9TT = m4.GetString("SbrExt9TT");
public static string SbrExt10 = m4.GetString("SbrExt10");
public static string SbrExt10TT = m4.GetString("SbrExt10TT");
public static string SbrExt11 = m4.GetString("SbrExt11");
public static string SbrExt11TT = m4.GetString("SbrExt11TT");
public static string SbrExt12 = m4.GetString("SbrExt12");
public static string SbrExt12TT = m4.GetString("SbrExt12TT");
public static string SbrExt13 = m4.GetString("SbrExt13");
public static string SbrExt13TT = m4.GetString("SbrExt13TT");
public static string SbrExt14 = m4.GetString("SbrExt14");
public static string SbrExt14TT = m4.GetString("SbrExt14TT");
public static string SbrExt15 = m4.GetString("SbrExt15");
public static string SbrExt15TT = m4.GetString("SbrExt15TT");
public static string SbrExtSum0 = m4.GetString("SbrExtSum0");
public static string SbrExtSum1 = m4.GetString("SbrExtSum1");
public static string SbrExtNote0subhdr = m4.GetString("SbrExtNote0subhdr");
public static string SbrExtNote1 = m4.GetString("SbrExtNote1");
public static string SbrExtNote2 = m4.GetString("SbrExtNote2");
public static string SbrExtNote3 = m4.GetString("SbrExtNote3");
public static string SbrExtNote4 = m4.GetString("SbrExtNote4");
public static string SbrExtNote5subhdr = m4.GetString("SbrExtNote5subhdr");
public static string SbrExtNote6 = m4.GetString("SbrExtNote6");
public static string SbrExtNote7 = m4.GetString("SbrExtNote7");
public static string SbrExtNote8 = m4.GetString("SbrExtNote8");
public static string SbrExtNote9 = m4.GetString("SbrExtNote9");
public static string SbrExtNote10subhdr = m4.GetString("SbrExtNote10subhdr");
public static string SbrExtNote11 = m4.GetString("SbrExtNote11");
public static string SbrExtNote12 = m4.GetString("SbrExtNote12");
public static string SbrExtNote13subhdr = m4.GetString("SbrExtNote13subhdr");
public static string SbrExtNote14 = m4.GetString("SbrExtNote14");
public static string SbrExtNote15 = m4.GetString("SbrExtNote15");
public static string SbrExtNote16 = m4.GetString("SbrExtNote16");
public static string RepoTitle = m4.GetString("RepoTitle");
public static string RepoBtn = m4.GetString("RepoBtn");
public static string Repo0 = m4.GetString("Repo0");
public static string Repo0TT = m4.GetString("Repo0TT");
public static string Repo1 = m4.GetString("Repo1");
public static string Repo1TT = m4.GetString("Repo1TT");
public static string RepoSum0 = m4.GetString("RepoSum0");
public static string RepoSum1 = m4.GetString("RepoSum1");
public static string PrxTitle = m4.GetString("PrxTitle");
public static string PrxBtn = m4.GetString("PrxBtn");
public static string Prx0 = m4.GetString("Prx0");
public static string Prx0TT = m4.GetString("Prx0TT");
public static string Prx1 = m4.GetString("Prx1");
public static string Prx1TT = m4.GetString("Prx1TT");
public static string Prx2 = m4.GetString("Prx2");
public static string Prx2TT = m4.GetString("Prx2TT");
public static string Prx3 = m4.GetString("Prx3");
public static string Prx3TT = m4.GetString("Prx3TT");
public static string Prx4 = m4.GetString("Prx4");
public static string Prx4TT = m4.GetString("Prx4TT");
public static string Prx5 = m4.GetString("Prx5");
public static string Prx5TT = m4.GetString("Prx5TT");
public static string Prx6 = m4.GetString("Prx6");
public static string Prx6TT = m4.GetString("Prx6TT");
public static string Prx7 = m4.GetString("Prx7");
public static string Prx7TT = m4.GetString("Prx7TT");
public static string Prx8 = m4.GetString("Prx8");
public static string Prx8TT = m4.GetString("Prx8TT");
public static string Prx9 = m4.GetString("Prx9");
public static string Prx9TT = m4.GetString("Prx9TT");
public static string Prx10 = m4.GetString("Prx10");
public static string Prx10TT = m4.GetString("Prx10TT");
public static string Prx11 = m4.GetString("Prx11");
public static string Prx11TT = m4.GetString("Prx11TT");
public static string PrxSum0 = m4.GetString("PrxSum0");
public static string PrxSum1 = m4.GetString("PrxSum1");
public static string PrxSum2 = m4.GetString("PrxSum2");
public static string PrxSum3 = m4.GetString("PrxSum3");
public static string PrxSum4 = m4.GetString("PrxSum4");
public static string PrxSum5 = m4.GetString("PrxSum5");
public static string PrxSum6 = m4.GetString("PrxSum6");
public static string PrxNote0 = m4.GetString("PrxNote0");
public static string PrxNote1 = m4.GetString("PrxNote1");
public static string PrxNote2 = m4.GetString("PrxNote2");
public static string PrxNote3 = m4.GetString("PrxNote3");
public static string PrxNote4 = m4.GetString("PrxNote4");
public static string PrxNote5 = m4.GetString("PrxNote5");
public static string PrxNote6 = m4.GetString("PrxNote6");
public static string PrxNote7 = m4.GetString("PrxNote7");
public static string PrxNote8 = m4.GetString("PrxNote8");
public static string PrxNote9 = m4.GetString("PrxNote9");
public static string PrxNote10 = m4.GetString("PrxNote10");
public static string PrxNote11 = m4.GetString("PrxNote11");
public static string PrxNote12 = m4.GetString("PrxNote12");
public static string ManSrvTitle = m4.GetString("ManSrvTitle");
public static string ManSrvBtn = m4.GetString("ManSrvBtn");
public static string ManSrv0 = m4.GetString("ManSrv0");
public static string ManSrv0TT = m4.GetString("ManSrv0TT");
public static string ManSrv1 = m4.GetString("ManSrv1");
public static string ManSrv1TT = m4.GetString("ManSrv1TT");
public static string ManSrv2 = m4.GetString("ManSrv2");
public static string ManSrv2TT = m4.GetString("ManSrv2TT");
public static string ManSrv3 = m4.GetString("ManSrv3");
public static string ManSrv3TT = m4.GetString("ManSrv3TT");
public static string ManSrv4 = m4.GetString("ManSrv4");
public static string ManSrv4TT = m4.GetString("ManSrv4TT");
public static string ManSrv5 = m4.GetString("ManSrv5");
public static string ManSrv5TT = m4.GetString("ManSrv5TT");
public static string ManSrv6 = m4.GetString("ManSrv6");
public static string ManSrv6TT = m4.GetString("ManSrv6TT");
public static string ManSrv7 = m4.GetString("ManSrv7");
public static string ManSrv7TT = m4.GetString("ManSrv7TT");
public static string ManSrv8 = m4.GetString("ManSrv8");
public static string ManSrv8TT = m4.GetString("ManSrv8TT");
public static string ManSrv9 = m4.GetString("ManSrv9");
public static string ManSrv9TT = m4.GetString("ManSrv9TT");
public static string ManSrv10 = m4.GetString("ManSrv10");
public static string ManSrv10TT = m4.GetString("ManSrv10TT");
public static string ManSrv11 = m4.GetString("ManSrv11");
public static string ManSrv11TT = m4.GetString("ManSrv11TT");
public static string ManSrvSum0 = m4.GetString("ManSrvSum0");
public static string ManSrvNote0 = m4.GetString("ManSrvNote0");
public static string ManSrvNote1 = m4.GetString("ManSrvNote1");
public static string JobSumTitle = m4.GetString("JobSumTitle");
public static string JobSumBtn = m4.GetString("JobSumBtn");
public static string JobSum0 = m4.GetString("JobSum0");
public static string JobSum0TT = m4.GetString("JobSum0TT");
public static string JobSum1 = m4.GetString("JobSum1");
public static string JobSum1TT = m4.GetString("JobSum1TT");
public static string JobSumSum0 = m4.GetString("JobSumSum0");
public static string JobSumNote0 = m4.GetString("JobSumNote0");
public static string JobSumNote1 = m4.GetString("JobSumNote1");
public static string JobConTitle = m4.GetString("JobConTitle");
public static string JobConBtn = m4.GetString("JobConBtn");
public static string JobCon0 = m4.GetString("JobCon0");
public static string JobCon0TT = m4.GetString("JobCon0TT");
public static string JobCon1 = m4.GetString("JobCon1");
public static string JobCon1TT = m4.GetString("JobCon1TT");
public static string JobCon2 = m4.GetString("JobCon2");
public static string JobCon2TT = m4.GetString("JobCon2TT");
public static string JobCon3 = m4.GetString("JobCon3");
public static string JobCon3TT = m4.GetString("JobCon3TT");
public static string JobCon4 = m4.GetString("JobCon4");
public static string JobCon4TT = m4.GetString("JobCon4TT");
public static string JobCon5 = m4.GetString("JobCon5");
public static string JobCon5TT = m4.GetString("JobCon5TT");
public static string JobCon6 = m4.GetString("JobCon6");
public static string JobCon6TT = m4.GetString("JobCon6TT");
public static string JobCon7 = m4.GetString("JobCon7");
public static string JobCon7TT = m4.GetString("JobCon7TT");
public static string JobConSum0 = m4.GetString("JobConSum0");
public static string JobConNote0subhdr = m4.GetString("JobConNote0subhdr");
public static string JobConNote1 = m4.GetString("JobConNote1");
public static string JobConNote2 = m4.GetString("JobConNote2");
public static string JobConNote3 = m4.GetString("JobConNote3");
public static string JobConNote4subhdr = m4.GetString("JobConNote4subhdr");
public static string JobConNote5bold = m4.GetString("JobConNote5bold");
public static string JobConNoteSqlTableRow1Col1 = m4.GetString("JobConNoteSqlTableRow1Col1");
public static string JobConNoteSqlTableRow1Col2 = m4.GetString("JobConNoteSqlTableRow1Col2");
public static string JobConNoteSqlTableRow1Col3 = m4.GetString("JobConNoteSqlTableRow1Col3");
public static string JobConNoteSqlTableRow2Col1 = m4.GetString("JobConNoteSqlTableRow2Col1");
public static string JobConNoteSqlTableRow2Col2 = m4.GetString("JobConNoteSqlTableRow2Col2");
public static string JobConNoteSqlTableRow2Col3 = m4.GetString("JobConNoteSqlTableRow2Col3");
public static string JobConNoteSqlTableRowRow3Col1 = m4.GetString("JobConNoteSqlTableRowRow3Col1");
public static string JobConNoteSqlTableRow3Col2 = m4.GetString("JobConNoteSqlTableRow3Col2");
public static string JobConNoteSqlTableRow3Col3 = m4.GetString("JobConNoteSqlTableRow3Col3");
public static string JobConNoteSqlTableRow4Col1 = m4.GetString("JobConNoteSqlTableRow4Col1");
public static string JobConNoteSqlTableRow4Col2 = m4.GetString("JobConNoteSqlTableRow4Col2");
public static string JobConNoteSqlTableRow4Col3 = m4.GetString("JobConNoteSqlTableRow4Col3");
public static string JobConNoteSqlTableNote0 = m4.GetString("JobConNoteSqlTableNote0");
public static string JobConNoteSqlTableNote1 = m4.GetString("JobConNoteSqlTableNote1");
public static string JobConNoteSqlTableNote2 = m4.GetString("JobConNoteSqlTableNote2");
public static string JobConNoteSqlTableNote3 = m4.GetString("JobConNoteSqlTableNote3");
public static string JobConNoteSqlTableNote4 = m4.GetString("JobConNoteSqlTableNote4");
public static string TaskConTitle = m4.GetString("TaskConTitle");
public static string TaskConBtn = m4.GetString("TaskConBtn");
public static string TaskCon0 = m4.GetString("TaskCon0");
public static string TaskCon0TT = m4.GetString("TaskCon0TT");
public static string TaskCon1 = m4.GetString("TaskCon1");
public static string TaskCon1TT = m4.GetString("TaskCon1TT");
public static string TaskCon2 = m4.GetString("TaskCon2");
public static string TaskCon2TT = m4.GetString("TaskCon2TT");
public static string TaskCon3 = m4.GetString("TaskCon3");
public static string TaskCon3TT = m4.GetString("TaskCon3TT");
public static string TaskCon4 = m4.GetString("TaskCon4");
public static string TaskCon4TT = m4.GetString("TaskCon4TT");
public static string TaskCon5 = m4.GetString("TaskCon5");
public static string TaskCon5TT = m4.GetString("TaskCon5TT");
public static string TaskCon6 = m4.GetString("TaskCon6");
public static string TaskCon6TT = m4.GetString("TaskCon6TT");
public static string TaskCon7 = m4.GetString("TaskCon7");
public static string TaskCon7TT = m4.GetString("TaskCon7TT");
public static string TaskConSum0 = m4.GetString("TaskConSum0");
public static string TaskConNote0 = m4.GetString("TaskConNote0");
public static string RegTitle = m4.GetString("RegTitle");
public static string RegBtn = m4.GetString("RegBtn");
public static string Reg0 = m4.GetString("Reg0");
public static string Reg0TT = m4.GetString("Reg0TT");
public static string Reg1 = m4.GetString("Reg1");
public static string Reg1TT = m4.GetString("Reg1TT");
public static string RegSum0 = m4.GetString("RegSum0");
public static string RegNote0 = m4.GetString("RegNote0");
public static string RegNote1 = m4.GetString("RegNote1");
public static string JobInfoTitle = m4.GetString("JobInfoTitle");
public static string JobInfoBtn = m4.GetString("JobInfoBtn");
public static string JobInfo0 = m4.GetString("JobInfo0");
public static string JobInfo0TT = m4.GetString("JobInfo0TT");
public static string JobInfo1 = m4.GetString("JobInfo1");
public static string JobInfo1TT = m4.GetString("JobInfo1TT");
public static string JobInfo2 = m4.GetString("JobInfo2");
public static string JobInfo2TT = m4.GetString("JobInfo2TT");
public static string JobInfo3 = m4.GetString("JobInfo3");
public static string JobInfo3TT = m4.GetString("JobInfo3TT");
public static string JobInfo4 = m4.GetString("JobInfo4");
public static string JobInfo4TT = m4.GetString("JobInfo4TT");
public static string JobInfo5 = m4.GetString("JobInfo5");
public static string JobInfo5TT = m4.GetString("JobInfo5TT");
public static string JobInfo6 = m4.GetString("JobInfo6");
public static string JobInfo6TT = m4.GetString("JobInfo6TT");
public static string JobInfo7 = m4.GetString("JobInfo7");
public static string JobInfo7TT = m4.GetString("JobInfo7TT");
public static string JobInfo8 = m4.GetString("JobInfo8");
public static string JobInfo8TT = m4.GetString("JobInfo8TT");
public static string JobInfo9 = m4.GetString("JobInfo9");
public static string JobInfo9TT = m4.GetString("JobInfo9TT");
public static string JobInfo10 = m4.GetString("JobInfo10");
public static string JobInfo10TT = m4.GetString("JobInfo10TT");
public static string JobInfo11 = m4.GetString("JobInfo11");
public static string JobInfo11TT = m4.GetString("JobInfo11TT");
public static string JobInfo12 = m4.GetString("JobInfo12");
public static string JobInfo12TT = m4.GetString("JobInfo12TT");
public static string JobInfo13 = m4.GetString("JobInfo13");
public static string JobInfo13TT = m4.GetString("JobInfo13TT");
public static string JobInfoSum0 = m4.GetString("JobInfoSum0");
public static string JobInfoNote0 = m4.GetString("JobInfoNote0");
public static string JssTitle = m4.GetString("JssTitle");
public static string JssBtn = m4.GetString("JssBtn");
public static string Jss0 = m4.GetString("Jss0");
public static string Jss0TT = m4.GetString("Jss0TT");
public static string Jss1 = m4.GetString("Jss1");
public static string Jss1TT = m4.GetString("Jss1TT");
public static string Jss2 = m4.GetString("Jss2");
public static string Jss2TT = m4.GetString("Jss2TT");
public static string Jss3 = m4.GetString("Jss3");
public static string Jss3TT = m4.GetString("Jss3TT");
public static string Jss4 = m4.GetString("Jss4");
public static string Jss4TT = m4.GetString("Jss4TT");
public static string Jss5 = m4.GetString("Jss5");
public static string Jss5TT = m4.GetString("Jss5TT");
public static string Jss6 = m4.GetString("Jss6");
public static string Jss6TT = m4.GetString("Jss6TT");
public static string Jss7 = m4.GetString("Jss7");
public static string Jss7TT = m4.GetString("Jss7TT");
public static string Jss8 = m4.GetString("Jss8");
public static string Jss8TT = m4.GetString("Jss8TT");
public static string Jss9 = m4.GetString("Jss9");
public static string Jss9TT = m4.GetString("Jss9TT");
public static string Jss10 = m4.GetString("Jss10");
public static string Jss10TT = m4.GetString("Jss10TT");
public static string Jss11 = m4.GetString("Jss11");
public static string Jss11TT = m4.GetString("Jss11TT");
public static string Jss12 = m4.GetString("Jss12");
public static string Jss12TT = m4.GetString("Jss12TT");
public static string Jss13 = m4.GetString("Jss13");
public static string Jss13TT = m4.GetString("Jss13TT");
public static string Jss14 = m4.GetString("Jss14");
public static string Jss14TT = m4.GetString("Jss14TT");
public static string Jss15 = m4.GetString("Jss15");
public static string Jss15TT = m4.GetString("Jss15TT");
public static string JssSum0 = m4.GetString("JssSum0");
public static string JssNote0subhdr = m4.GetString("JssNote0subhdr");
public static string JssNote1 = m4.GetString("JssNote1");
public static string JssNote2 = m4.GetString("JssNote2");
public static string JssNote3 = m4.GetString("JssNote3");
public static string JssNote4 = m4.GetString("JssNote4");
public static string JssNote5 = m4.GetString("JssNote5");
public static string JssNote6 = m4.GetString("JssNote6");
public static string JssNote7 = m4.GetString("JssNote7");
public static string JssNote8 = m4.GetString("JssNote8");
public static string JssNote9 = m4.GetString("JssNote9");
public static string JssNote10 = m4.GetString("JssNote10");
public static string Vb365Banner = m4.GetString("Vb365Banner");
public static string v365NavTitle0 = m4.GetString("v365NavTitle0");
public static string v365NavValue0 = m4.GetString("v365NavValue0");
public static string v365NavTitle1 = m4.GetString("v365NavTitle1");
public static string v365NavValue1 = m4.GetString("v365NavValue1");
public static string v365NavTitle2 = m4.GetString("v365NavTitle2");
public static string v365NavValue2 = m4.GetString("v365NavValue2");
public static string v365NavTitle3 = m4.GetString("v365NavTitle3");
public static string v365NavValue3 = m4.GetString("v365NavValue3");
public static string v365NavTitle4 = m4.GetString("v365NavTitle4");
public static string v365NavValue4 = m4.GetString("v365NavValue4");
public static string v365NavTitle5 = m4.GetString("v365NavTitle5");
public static string v365NavValue5 = m4.GetString("v365NavValue5");
public static string v365NavTitle6 = m4.GetString("v365NavTitle6");
public static string v365NavValue6 = m4.GetString("v365NavValue6");
public static string v365NavTitle7 = m4.GetString("v365NavTitle7");
public static string v365NavValue7 = m4.GetString("v365NavValue7");
public static string v365NavTitle8 = m4.GetString("v365NavTitle8");
public static string v365NavValue8 = m4.GetString("v365NavValue8");
public static string v365NavTitle9 = m4.GetString("v365NavTitle9");
public static string v365NavValue9 = m4.GetString("v365NavValue9");
public static string v365NavTitle10 = m4.GetString("v365NavTitle10");
public static string v365NavValue10 = m4.GetString("v365NavValue10");
public static string v365NavTitle11 = m4.GetString("v365NavTitle11");
public static string v365NavValue11 = m4.GetString("v365NavValue11");
public static string v365NavTitle12 = m4.GetString("v365NavTitle12");
public static string v365NavValue12 = m4.GetString("v365NavValue12");
public static string v365NavTitle13 = m4.GetString("v365NavTitle13");
public static string v365NavValue13 = m4.GetString("v365NavValue13");
public static string v365NavTitle14 = m4.GetString("v365NavTitle14");
public static string v365NavValue14 = m4.GetString("v365NavValue14");
public static string helpMenu = m4.GetString("helpMenu");
}}
