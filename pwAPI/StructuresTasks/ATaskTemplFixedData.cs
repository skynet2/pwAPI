using System;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using JQEditor;
using pwAPI;

namespace JQEditor.Classes
{
    public class ATaskTemplFixedData
    {
        public int m_ID;
        public string m_szName;
        public bool m_bHasSign;
        public string m_pszSignature;
        public int m_ulType;
        public int m_ulTimeLimit;
        public bool m_bOfflineFail;
        public bool m_bAbsFail;
        public task_tm m_tmAbsFailTime;
        public bool m_bItemNotTakeOff;
        public bool m_bAbsTime;
        public int m_ulTimetable;
        public byte[] m_tmType;
        public task_tm[] m_tmStart;
        public task_tm[] m_tmEnd;
        public int m_lAvailFrequency;
        public int m_lPeriodLimit;
        public bool m_bChooseOne;
        public bool m_bRandOne;
        public bool m_bExeChildInOrder;
        public bool m_bParentAlsoFail;
        public bool m_bParentAlsoSucc;
        public bool m_bCanGiveUp;
        public bool m_bCanRedo;
        public bool m_bCanRedoAfterFailure;
        public bool m_bClearAsGiveUp;
        public bool m_bNeedRecord;
        public bool m_bFailAsPlayerDie;
        public int m_ulMaxReceiver;
        public bool m_bDelvInZone;
        public int m_ulDelvWorld;
        public int m_ulDelvRegionCnt;
        public Task_Region[] m_pDelvRegion;
        public bool m_bEnterRegionFail;
        public int m_ulEnterRegionWorld;
        public int m_ulEnterRegionCnt;
        public Task_Region[] m_pEnterRegion;
        public bool m_bLeaveRegionFail;
        public int m_ulLeaveRegionWorld;
        public int m_ulLeaveRegionCnt;
        public Task_Region[] m_pLeaveRegion;
        public bool m_bLeaveForceFail;
        public bool m_bTransTo;
        public int m_ulTransWldId;
        public ZONE_VERT m_TransPt;
        public int m_lMonsCtrl;
        public bool m_bTrigCtrl;
        public bool m_bAutoDeliver;
        public bool m_bDisplayInExclusiveUI;
        public bool m_bReadyToNotifyServer;
        public bool m_bUsedInTokenShop;
        public bool m_bDeathTrig;
        public bool m_bClearAcquired;
        public int m_ulSuitableLevel;
        public bool m_bShowPrompt;
        public bool m_bKeyTask;
        public int m_ulDelvNPC;
        public int m_ulAwardNPC;
        public bool m_bSkillTask;
        public bool m_bCanSeekOut;
        public bool m_bShowDirection;
        public bool m_bMarriage;
        public int m_ulChangeKeyCnt;
        public int[] m_plChangeKey;
        public int[] m_plChangeKeyValue;
        public bool[] m_pbChangeType;
        public bool m_bSwitchSceneFail;
        public bool m_bHidden;
        public bool m_bDeliverySkill;
        public int m_iDeliveredSkillID;
        public int m_iDeliveredSkillLevel;
        public bool m_bShowGfxFinished;
        public bool m_bChangePQRanking;
        public bool m_bCompareItemAndInventory;
        public int m_ulInventorySlotNum;
        public bool m_bPQTask;
        public int m_ulPQExpCnt;
        public byte[][] m_pszPQExp;
        public TASK_EXPRESSION[] m_pPQExpArr;
        public bool m_bPQSubTask;
        public bool m_bClearContrib;
        public int m_ulMonsterContribCnt;
        public MONSTERS_CONTRIB[] m_MonstersContrib;
        public int m_iPremNeedRecordTasksNum;
        public bool m_bShowByNeedRecordTasksNum;
        public int m_iPremiseFactionContrib;
        public bool m_bShowByFactionContrib;
        public bool m_bAccountTaskLimit;
        public bool m_bRoleTaskLimit;
        public int m_ulAccountTaskLimitCnt;
        public bool m_bLeaveFactionFail;
        public bool m_bNotIncCntWhenFailed;
        public bool m_bNotClearItemWhenFailed;
        public bool m_bDisplayInTitleTaskUI;
        public byte m_ucPremiseTransformedForm;
        public bool m_bShowByTransformed;
        public int m_ulPremise_Lev_Min;
        public int m_ulPremise_Lev_Max;
        public int m_bPremCheckMaxHistoryLevel;
        public bool m_bShowByLev;
        public bool m_bPremCheckReincarnation;
        public int m_ulPremReincarnationMin;
        public int m_ulPremReincarnationMax;
        public bool m_bShowByReincarnation;
        public bool m_bPremCheckRealmLevel;
        public int m_ulPremRealmLevelMin;
        public int m_ulPremRealmLevelMax;
        public bool m_bPremCheckRealmExpFull;
        public bool m_bShowByRealmLevel;
        public int m_ulPremItems;
        public ITEM_WANTED[] m_PremItems;
        public bool m_bShowByItems;
        public bool m_bPremItemsAnyOne;
        public int m_ulGivenItems;
        public int m_ulGivenCmnCount;
        public int m_ulGivenTskCount;
        public ITEM_WANTED[] m_GivenItems;
        public int m_ulPremise_Deposit;
        public bool m_bShowByDeposit;
        public int m_lPremise_Reputation;
        public int m_lPremise_RepuMax;
        public bool m_bShowByRepu;
        public int m_ulPremise_Task_Count;
        public int[] m_ulPremise_Tasks;
        public bool m_bShowByPreTask;
        public int m_ulPremise_Task_Least_Num;
        public int m_ulPremise_Period;
        public bool m_bShowByPeriod;
        public int m_ulPremise_Faction;
        public int m_iPremise_FactionRole;
        public bool m_bShowByFaction;
        public int m_ulGender;
        public bool m_bShowByGender;
        public int m_ulOccupations;
        public int[] m_Occupations;
        public bool m_bShowByOccup;
        public bool m_bPremise_Spouse;
        public bool m_bShowBySpouse;
        public bool m_bPremiseWeddingOwner;
        public bool m_bShowByWeddingOwner;
        public bool m_bGM;
        public bool m_bShieldUser;
        public bool m_bShowByRMB;
        public int m_ulPremRMBMin;
        public int m_ulPremRMBMax;
        public bool m_bCharTime;
        public bool m_bShowByCharTime;
        public int m_iCharStartTime;
        public int m_iCharEndTime;
        public task_tm m_tmCharEndTime;
        public int m_ulCharTimeGreaterThan;
        public int m_ulPremise_Cotask;
        public int m_ulCoTaskCond;
        public int m_ulMutexTaskCount;
        public int[] m_ulMutexTasks;
        public int[] m_lSkillLev;
        public sbyte m_DynTaskType;
        public int m_ulSpecialAward;
        public bool m_bTeamwork;
        public bool m_bRcvByTeam;
        public bool m_bSharedTask;
        public bool m_bSharedAchieved;
        public bool m_bCheckTeammate;
        public float m_fTeammateDist;
        public bool m_bAllFail;
        public bool m_bCapFail;
        public bool m_bCapSucc;
        public float m_fSuccDist;
        public bool m_bDismAsSelfFail;
        public bool m_bRcvChckMem;
        public float m_fRcvMemDist;
        public bool m_bCntByMemPos;
        public float m_fCntMemDist;
        public bool m_bAllSucc;
        public bool m_bCoupleOnly;
        public bool m_bDistinguishedOcc;
        public int m_ulTeamMemsWanted;
        public TEAM_MEM_WANTED[] m_TeamMemsWanted;
        public bool m_bShowByTeam;
        public bool m_bPremNeedComp;
        public int m_nPremExp1AndOrExp2;
        public COMPARE_KEY_VALUE m_Prem1KeyValue;
        public COMPARE_KEY_VALUE m_Prem2KeyValue;
        public bool m_bPremCheckForce;
        public int m_iPremForce;
        public bool m_bShowByForce;
        public int m_iPremForceReputation;
        public bool m_bShowByForceReputation;
        public int m_iPremForceContribution;
        public bool m_bShowByForceContribution;
        public int m_iPremForceExp;
        public bool m_bShowByForceExp;
        public int m_iPremForceSP;
        public bool m_bShowByForceSP;
        public int m_iPremForceActivityLevel;
        public bool m_bShowByForceActivityLevel;
        public bool m_bPremIsKing;
        public bool m_bShowByKing;
        public bool m_bPremNotInTeam;
        public bool m_bShowByNotInTeam;
        public int m_iPremTitleNumTotal;
        public int m_iPremTitleNumRequired;
        public int[] m_PremTitles;
        public bool m_bShowByTitle;
        public int[] m_iPremHistoryStageIndex;
        public bool m_bShowByHistoryStage;
        public int m_ulPremGeneralCardCount;
        public bool m_bShowByGeneralCard;
        public int m_iPremGeneralCardRank;
        public int m_ulPremGeneralCardRankCount;
        public bool m_bShowByGeneralCardRank;
        public int m_enumMethod;
        public int m_enumFinishType;
        public int m_ulPlayerWanted;
        public PLAYER_WANTED[] m_PlayerWanted;
        public int m_ulMonsterWanted;
        public MONSTER_WANTED[] m_MonsterWanted;
        public int m_ulItemsWanted;
        public ITEM_WANTED[] m_ItemsWanted;
        public int m_ulGoldWanted;
        public int m_iFactionContribWanted;
        public int m_iFactionExpContribWanted;
        public int m_ulNPCToProtect;
        public int m_ulProtectTimeLen;
        public int m_ulNPCMoving;
        public int m_ulNPCDestSite;
        public Task_Region[] m_pReachSite;
        public int m_ulReachSiteCnt;
        public int m_ulReachSiteId;
        public int m_ulWaitTime;
        public ZONE_VERT m_TreasureStartZone;
        public byte m_ucZonesNumX;
        public byte m_ucZonesNumZ;
        public byte m_ucZoneSide;
        public Task_Region[] m_pLeaveSite;
        public int m_ulLeaveSiteCnt;
        public int m_ulLeaveSiteId;
        public bool m_bFinNeedComp;
        public int m_nFinExp1AndOrExp2;
        public COMPARE_KEY_VALUE m_Fin1KeyValue;
        public COMPARE_KEY_VALUE m_Fin2KeyValue;
        public int m_ulExpCnt;
        public byte[][] m_pszExp;
        public TASK_EXPRESSION[] m_pExpArr;
        public int m_ulTaskCharCnt;
        public byte[][] m_pTaskChar;
        public byte m_ucTransformedForm;
        public int m_ulReachLevel;
        public int m_ulReachReincarnationCount;
        public int m_ulReachRealmLevel;
        public int m_uiEmotion;
        public int m_ulAwardType_S;
        public int m_ulAwardType_F;
        public AWARD_DATA m_Award_S;
        public AWARD_DATA m_Award_F;
        public AWARD_RATIO_SCALE m_AwByRatio_S;
        public AWARD_RATIO_SCALE m_AwByRatio_F;
        public AWARD_ITEMS_SCALE m_AwByItems_S;
        public AWARD_ITEMS_SCALE m_AwByItems_F;
        public int m_ulParent;
        public int m_ulPrevSibling;
        public int m_ulNextSibling;
        public int m_ulFirstChild;
        public bool m_bIsLibraryTask;
        public float m_fLibraryTasksProbability;
        public bool m_bIsUniqueStorageTask;
        public CONVERSATION conversation;
        public int SubQuestsCount;
        public ATaskTemplFixedData[] SubQuests;

        public bool m_bPromptWhenAutoDeliver;
        public int pszSignaturePointer, tmStartPointer, tmEndPointer, DelvRegionPointer, EnterRegionPointer, LeaveRegionPointer,
            ChangeKeyPointer, ChangeKeyValuePointer, ChangeTypePointer, PQExpPointer, PQExpArrPointer, MonstersContribPointer,
            PremItemsPointer, GivenItemsPointer, TeamMemsWantedPointer, PlayerWantedPointer, MonsterWantedPointer,
            ItemsWantedPointer, ReachSitePointer, LeaveSitePointer, pszExpPointer, ExpArrPointer, TaskCharPointer,
            Award_S_Pointer, Award_F_Pointer, AwByRatio_S_Pointer, AwByRatio_F_Pointer, AwByItems_S_Pointer, AwByItems_F_Pointer,

            PremTitlesPointer;

        public ATaskTemplFixedData(BinaryReader br, int version)
        {
            m_ID = br.ReadInt32();
			m_szName = TasksExtensions.ReadTaskChar(br,60, (int)m_ID);
            m_bHasSign = br.ReadBoolean();
            pszSignaturePointer = br.ReadInt32();
            m_ulType = br.ReadInt32();
            m_ulTimeLimit = br.ReadInt32();
            m_bOfflineFail = br.ReadBoolean();
            m_bAbsFail = br.ReadBoolean();
            m_tmAbsFailTime = task_tm.Read(br);
            m_bItemNotTakeOff = br.ReadBoolean();
            m_bAbsTime = br.ReadBoolean();
            m_ulTimetable = br.ReadInt32();
            m_tmType = br.ReadBytes(24);
            tmStartPointer = br.ReadInt32();
            tmEndPointer = br.ReadInt32();
            m_lAvailFrequency = br.ReadInt32();
            m_lPeriodLimit = br.ReadInt32();
            m_bChooseOne = br.ReadBoolean();
            m_bRandOne = br.ReadBoolean();
            m_bExeChildInOrder = br.ReadBoolean();
            m_bParentAlsoFail = br.ReadBoolean();
            m_bParentAlsoSucc = br.ReadBoolean();
            m_bCanGiveUp = br.ReadBoolean();
            m_bCanRedo = br.ReadBoolean();
            m_bCanRedoAfterFailure = br.ReadBoolean();
            m_bClearAsGiveUp = br.ReadBoolean();
            m_bNeedRecord = br.ReadBoolean();
            m_bFailAsPlayerDie = br.ReadBoolean();
            m_ulMaxReceiver = br.ReadInt32();
            m_bDelvInZone = br.ReadBoolean();
            m_ulDelvWorld = br.ReadInt32();
            m_ulDelvRegionCnt = br.ReadInt32();
            DelvRegionPointer = br.ReadInt32();
            m_bEnterRegionFail = br.ReadBoolean();
            m_ulEnterRegionWorld = br.ReadInt32();
            m_ulEnterRegionCnt = br.ReadInt32();
            EnterRegionPointer = br.ReadInt32();
            m_bLeaveRegionFail = br.ReadBoolean();
            m_ulLeaveRegionWorld = br.ReadInt32();
            m_ulLeaveRegionCnt = br.ReadInt32();
            LeaveRegionPointer = br.ReadInt32();
            m_bLeaveForceFail = br.ReadBoolean();
            m_bTransTo = br.ReadBoolean();
            m_ulTransWldId = br.ReadInt32();
            m_TransPt = ZONE_VERT.Read(br);
            m_lMonsCtrl = br.ReadInt32();
            m_bTrigCtrl = br.ReadBoolean();
            m_bAutoDeliver = br.ReadBoolean();
            if (version <= 111)
                m_bPromptWhenAutoDeliver = br.ReadBoolean();
            if (version >= 118)
                m_bDisplayInExclusiveUI = br.ReadBoolean();
            m_bReadyToNotifyServer = br.ReadBoolean();
            if (version >= 118)
                m_bUsedInTokenShop = br.ReadBoolean();
            m_bDeathTrig = br.ReadBoolean();
            m_bClearAcquired = br.ReadBoolean();
            m_ulSuitableLevel = br.ReadInt32();
            m_bShowPrompt = br.ReadBoolean();
            m_bKeyTask = br.ReadBoolean();
            m_ulDelvNPC = br.ReadInt32();
            m_ulAwardNPC = br.ReadInt32();
            m_bSkillTask = br.ReadBoolean();
            m_bCanSeekOut = br.ReadBoolean();
            m_bShowDirection = br.ReadBoolean();
            m_bMarriage = br.ReadBoolean();
            m_ulChangeKeyCnt = br.ReadInt32();
            ChangeKeyPointer = br.ReadInt32();
            ChangeKeyValuePointer = br.ReadInt32();
            ChangeTypePointer = br.ReadInt32();
            m_bSwitchSceneFail = br.ReadBoolean();
            m_bHidden = br.ReadBoolean();
            m_bDeliverySkill = br.ReadBoolean();
            m_iDeliveredSkillID = br.ReadInt32();
            m_iDeliveredSkillLevel = br.ReadInt32();
            m_bShowGfxFinished = br.ReadBoolean();
            m_bChangePQRanking = br.ReadBoolean();
            m_bCompareItemAndInventory = br.ReadBoolean();
            m_ulInventorySlotNum = br.ReadInt32();
            m_bPQTask = br.ReadBoolean();
            m_ulPQExpCnt = br.ReadInt32();
            PQExpPointer = br.ReadInt32();
            PQExpArrPointer = br.ReadInt32();
            m_bPQSubTask = br.ReadBoolean();
            m_bClearContrib = br.ReadBoolean();
            m_ulMonsterContribCnt = br.ReadInt32();
            MonstersContribPointer = br.ReadInt32();
            m_iPremNeedRecordTasksNum = br.ReadInt32();
            m_bShowByNeedRecordTasksNum = br.ReadBoolean();
            m_iPremiseFactionContrib = br.ReadInt32();
            m_bShowByFactionContrib = br.ReadBoolean();
            m_bAccountTaskLimit = br.ReadBoolean();
            if (version >= 118)
                m_bRoleTaskLimit = br.ReadBoolean();
            m_ulAccountTaskLimitCnt = br.ReadInt32();
            m_bLeaveFactionFail = br.ReadBoolean();
            if (version >= 111)
                m_bNotIncCntWhenFailed = br.ReadBoolean();
            if (version >= 108)
                m_bNotClearItemWhenFailed = br.ReadBoolean();
            if (version >= 111)
                m_bDisplayInTitleTaskUI = br.ReadBoolean();
            m_ucPremiseTransformedForm = br.ReadByte();
            m_bShowByTransformed = br.ReadBoolean();
            m_ulPremise_Lev_Min = br.ReadInt32();
            m_ulPremise_Lev_Max = br.ReadInt32();
            if (version >= 118)
                m_bPremCheckMaxHistoryLevel = br.ReadInt32();
            m_bShowByLev = br.ReadBoolean();
            if (version >= 118)
            {
                m_bPremCheckReincarnation = br.ReadBoolean();
                m_ulPremReincarnationMin = br.ReadInt32();
                m_ulPremReincarnationMax = br.ReadInt32();
                m_bShowByReincarnation = br.ReadBoolean();
                m_bPremCheckRealmLevel = br.ReadBoolean();
                m_ulPremRealmLevelMin = br.ReadInt32();
                m_ulPremRealmLevelMax = br.ReadInt32();
                m_bPremCheckRealmExpFull = br.ReadBoolean();
                m_bShowByRealmLevel = br.ReadBoolean();
            }
            m_ulPremItems = br.ReadInt32();
            PremItemsPointer = br.ReadInt32();
            m_bShowByItems = br.ReadBoolean();
            m_bPremItemsAnyOne = br.ReadBoolean();
            m_ulGivenItems = br.ReadInt32();
            m_ulGivenCmnCount = br.ReadInt32();
            m_ulGivenTskCount = br.ReadInt32();
            GivenItemsPointer = br.ReadInt32();
            m_ulPremise_Deposit = br.ReadInt32();
            m_bShowByDeposit = br.ReadBoolean();
            m_lPremise_Reputation = br.ReadInt32();
            m_lPremise_RepuMax = br.ReadInt32();
            m_bShowByRepu = br.ReadBoolean();
            m_ulPremise_Task_Count = br.ReadInt32();
            m_ulPremise_Tasks = new int[20];
            for (int i = 0; i < m_ulPremise_Tasks.Length; ++i)
                m_ulPremise_Tasks[i] = br.ReadInt32();
            m_bShowByPreTask = br.ReadBoolean();
            m_ulPremise_Task_Least_Num = br.ReadInt32();
            m_ulPremise_Period = br.ReadInt32();
            m_bShowByPeriod = br.ReadBoolean();
            m_ulPremise_Faction = br.ReadInt32();
            m_iPremise_FactionRole = br.ReadInt32();
            m_bShowByFaction = br.ReadBoolean();
            m_ulGender = br.ReadInt32();
            m_bShowByGender = br.ReadBoolean();
            m_ulOccupations = br.ReadInt32();
            m_Occupations = new int[10];
            for (int i = 0; i < m_Occupations.Length; ++i)
                m_Occupations[i] = br.ReadInt32();
            m_bShowByOccup = br.ReadBoolean();
            m_bPremise_Spouse = br.ReadBoolean();
            m_bShowBySpouse = br.ReadBoolean();
            m_bPremiseWeddingOwner = br.ReadBoolean();
            m_bShowByWeddingOwner = br.ReadBoolean();
            m_bGM = br.ReadBoolean();
            m_bShieldUser = br.ReadBoolean();
            m_bShowByRMB = br.ReadBoolean();
            m_ulPremRMBMin = br.ReadInt32();
            m_ulPremRMBMax = br.ReadInt32();
            m_bCharTime = br.ReadBoolean();
            m_bShowByCharTime = br.ReadBoolean();
            m_iCharStartTime = br.ReadInt32();
            m_iCharEndTime = br.ReadInt32();
            m_tmCharEndTime = task_tm.Read(br);
            m_ulCharTimeGreaterThan = br.ReadInt32();
            m_ulPremise_Cotask = br.ReadInt32();
            m_ulCoTaskCond = br.ReadInt32();
            m_ulMutexTaskCount = br.ReadInt32();
            m_ulMutexTasks = new int[5];
            for (int i = 0; i < m_ulMutexTasks.Length; ++i)
                m_ulMutexTasks[i] = br.ReadInt32();
            m_lSkillLev = new int[4];
            for (int i = 0; i < m_lSkillLev.Length; ++i)
                m_lSkillLev[i] = br.ReadInt32();
            m_DynTaskType = br.ReadSByte();
            m_ulSpecialAward = br.ReadInt32();
            m_bTeamwork = br.ReadBoolean();
            m_bRcvByTeam = br.ReadBoolean();
            m_bSharedTask = br.ReadBoolean();
            m_bSharedAchieved = br.ReadBoolean();
            m_bCheckTeammate = br.ReadBoolean();
            m_fTeammateDist = br.ReadSingle();
            m_bAllFail = br.ReadBoolean();
            m_bCapFail = br.ReadBoolean();
            m_bCapSucc = br.ReadBoolean();
            m_fSuccDist = br.ReadSingle();
            m_bDismAsSelfFail = br.ReadBoolean();
            m_bRcvChckMem = br.ReadBoolean();
            m_fRcvMemDist = br.ReadSingle();
            m_bCntByMemPos = br.ReadBoolean();
            m_fCntMemDist = br.ReadSingle();
            m_bAllSucc = br.ReadBoolean();
            m_bCoupleOnly = br.ReadBoolean();
            m_bDistinguishedOcc = br.ReadBoolean();
            m_ulTeamMemsWanted = br.ReadInt32();
            TeamMemsWantedPointer = br.ReadInt32();
            m_bShowByTeam = br.ReadBoolean();
            m_bPremNeedComp = br.ReadBoolean();
            m_nPremExp1AndOrExp2 = br.ReadInt32();
            m_Prem1KeyValue = COMPARE_KEY_VALUE.Read(br);
            m_Prem2KeyValue = COMPARE_KEY_VALUE.Read(br);
            m_bPremCheckForce = br.ReadBoolean();
            m_iPremForce = br.ReadInt32();
            m_bShowByForce = br.ReadBoolean();
            m_iPremForceReputation = br.ReadInt32();
            m_bShowByForceReputation = br.ReadBoolean();
            m_iPremForceContribution = br.ReadInt32();
            m_bShowByForceContribution = br.ReadBoolean();
            m_iPremForceExp = br.ReadInt32();
            m_bShowByForceExp = br.ReadBoolean();
            m_iPremForceSP = br.ReadInt32();
            m_bShowByForceSP = br.ReadBoolean();
            m_iPremForceActivityLevel = br.ReadInt32();
            m_bShowByForceActivityLevel = br.ReadBoolean();
            if (version >= 108)
            {
                m_bPremIsKing = br.ReadBoolean();
                m_bShowByKing = br.ReadBoolean();
                m_bPremNotInTeam = br.ReadBoolean();
                m_bShowByNotInTeam = br.ReadBoolean();
            }
            if (version >= 111)
            {
                m_iPremTitleNumTotal = br.ReadInt32();
                m_iPremTitleNumRequired = br.ReadInt32();
                PremTitlesPointer = br.ReadInt32(); // указатель m_PremTitles
                m_bShowByTitle = br.ReadBoolean();
            }
            if (version >= 118)
            {
                m_iPremHistoryStageIndex = new int[2];
                for (int i = 0; i < m_iPremHistoryStageIndex.Length; ++i)
                    m_iPremHistoryStageIndex[i] = br.ReadInt32();
                m_bShowByHistoryStage = br.ReadBoolean();
                m_ulPremGeneralCardCount = br.ReadInt32();
                m_bShowByGeneralCard = br.ReadBoolean();
                m_iPremGeneralCardRank = br.ReadInt32();
                m_ulPremGeneralCardRankCount = br.ReadInt32();
                m_bShowByGeneralCardRank = br.ReadBoolean();
            }
            m_enumMethod = br.ReadInt32();
            m_enumFinishType = br.ReadInt32();
            m_ulPlayerWanted = br.ReadInt32();
            PlayerWantedPointer = br.ReadInt32();
            m_ulMonsterWanted = br.ReadInt32();
            MonsterWantedPointer = br.ReadInt32();
            m_ulItemsWanted = br.ReadInt32();
            ItemsWantedPointer = br.ReadInt32();
            m_ulGoldWanted = br.ReadInt32();
            m_iFactionContribWanted = br.ReadInt32();
            m_iFactionExpContribWanted = br.ReadInt32();
            m_ulNPCToProtect = br.ReadInt32();
            m_ulProtectTimeLen = br.ReadInt32();
            m_ulNPCMoving = br.ReadInt32();
            m_ulNPCDestSite = br.ReadInt32();
            ReachSitePointer = br.ReadInt32();
            m_ulReachSiteCnt = br.ReadInt32();
            m_ulReachSiteId = br.ReadInt32();
            m_ulWaitTime = br.ReadInt32();
            m_TreasureStartZone = ZONE_VERT.Read(br);
            m_ucZonesNumX = br.ReadByte();
            m_ucZonesNumZ = br.ReadByte();
            m_ucZoneSide = br.ReadByte();
            LeaveSitePointer = br.ReadInt32();
            m_ulLeaveSiteCnt = br.ReadInt32();
            m_ulLeaveSiteId = br.ReadInt32();
            m_bFinNeedComp = br.ReadBoolean();
            m_nFinExp1AndOrExp2 = br.ReadInt32();
            m_Fin1KeyValue = COMPARE_KEY_VALUE.Read(br);
            m_Fin2KeyValue = COMPARE_KEY_VALUE.Read(br);
            m_ulExpCnt = br.ReadInt32();
            pszExpPointer = br.ReadInt32();
            ExpArrPointer = br.ReadInt32();
            m_ulTaskCharCnt = br.ReadInt32();
            TaskCharPointer = br.ReadInt32();
            m_ucTransformedForm = br.ReadByte();
            if (version >= 118)
            {
                m_ulReachLevel = br.ReadInt32();
                m_ulReachReincarnationCount = br.ReadInt32();
                m_ulReachRealmLevel = br.ReadInt32();
                m_uiEmotion = br.ReadInt32();
            }
            m_ulAwardType_S = br.ReadInt32();
            m_ulAwardType_F = br.ReadInt32();
            Award_S_Pointer = br.ReadInt32();
            Award_F_Pointer = br.ReadInt32();
            AwByRatio_S_Pointer = br.ReadInt32();
            AwByRatio_F_Pointer = br.ReadInt32();
            AwByItems_S_Pointer = br.ReadInt32();
            AwByItems_F_Pointer = br.ReadInt32();

            m_ulParent = br.ReadInt32();
            m_ulPrevSibling = br.ReadInt32();
            m_ulNextSibling = br.ReadInt32();
            m_ulFirstChild = br.ReadInt32();
            m_bIsLibraryTask = br.ReadBoolean();
            m_fLibraryTasksProbability = br.ReadInt32();
            m_bIsUniqueStorageTask = br.ReadBoolean();

            if (m_bHasSign)
                m_pszSignature = TasksExtensions.ReadTaskChar(br,60, (int)m_ID);

            m_tmStart = new task_tm[m_ulTimetable];
            m_tmEnd = new task_tm[m_ulTimetable];
            for (int i = 0; i < m_tmStart.Length; ++i)
            {
                m_tmStart[i] = task_tm.Read(br);
                m_tmEnd[i] = task_tm.Read(br);
            }

            m_pDelvRegion = new Task_Region[m_ulDelvRegionCnt];
            for (int i = 0; i < m_pDelvRegion.Length; ++i)
                m_pDelvRegion[i] = Task_Region.Read(br);
            m_pEnterRegion = new Task_Region[m_ulEnterRegionCnt];
            for (int i = 0; i < m_pEnterRegion.Length; ++i)
                m_pEnterRegion[i] = Task_Region.Read(br);
            m_pLeaveRegion = new Task_Region[m_ulLeaveRegionCnt];
            for (int i = 0; i < m_pLeaveRegion.Length; ++i)
                m_pLeaveRegion[i] = Task_Region.Read(br);

            m_plChangeKey = new int[m_ulChangeKeyCnt];
            m_plChangeKeyValue = new int[m_ulChangeKeyCnt];
            m_pbChangeType = new bool[m_ulChangeKeyCnt];
            for (int i = 0; i < m_plChangeKey.Length; ++i)
            {
                m_plChangeKey[i] = br.ReadInt32();
                m_plChangeKeyValue[i] = br.ReadInt32();
                m_pbChangeType[i] = br.ReadBoolean();
            }

            m_pszPQExp = new byte[m_ulPQExpCnt][];
            m_pPQExpArr = new TASK_EXPRESSION[m_ulPQExpCnt];
            for (int i = 0; i < m_pszPQExp.Length; ++i)
            {
                m_pszPQExp[i] = br.ReadBytes(64);
                m_pPQExpArr[i] = TASK_EXPRESSION.Read(br);
            }

            m_MonstersContrib = new MONSTERS_CONTRIB[m_ulMonsterContribCnt];
            for (int i = 0; i < m_MonstersContrib.Length; ++i)
                m_MonstersContrib[i] = MONSTERS_CONTRIB.Read(br);
            m_PremItems = new ITEM_WANTED[m_ulPremItems];
            for (int i = 0; i < m_PremItems.Length; ++i)
                m_PremItems[i] = ITEM_WANTED.Read(br);
            m_GivenItems = new ITEM_WANTED[m_ulGivenItems];
            for (int i = 0; i < m_GivenItems.Length; ++i)
                m_GivenItems[i] = ITEM_WANTED.Read(br);
            m_TeamMemsWanted = new TEAM_MEM_WANTED[m_ulTeamMemsWanted];
            for (int i = 0; i < m_TeamMemsWanted.Length; ++i)
                m_TeamMemsWanted[i] = TEAM_MEM_WANTED.Read(br);
            m_PremTitles = new int[m_iPremTitleNumTotal];
            for (int i = 0; i < m_PremTitles.Length; i++)
                m_PremTitles[i] = br.ReadInt32();
            m_PlayerWanted = new PLAYER_WANTED[m_ulPlayerWanted];
            for (int i = 0; i < m_PlayerWanted.Length; ++i)
                m_PlayerWanted[i] = PLAYER_WANTED.Read(br);
            m_MonsterWanted = new MONSTER_WANTED[m_ulMonsterWanted];
            for (int i = 0; i < m_MonsterWanted.Length; ++i)
                m_MonsterWanted[i] = MONSTER_WANTED.Read(br);
            m_ItemsWanted = new ITEM_WANTED[m_ulItemsWanted];
            for (int i = 0; i < m_ItemsWanted.Length; ++i)
                m_ItemsWanted[i] = ITEM_WANTED.Read(br);
            m_pReachSite = new Task_Region[m_ulReachSiteCnt];
            for (int i = 0; i < m_pReachSite.Length; ++i)
                m_pReachSite[i] = Task_Region.Read(br);
            m_pLeaveSite = new Task_Region[m_ulLeaveSiteCnt];
            for (int i = 0; i < m_pLeaveSite.Length; ++i)
                m_pLeaveSite[i] = Task_Region.Read(br);

            m_pszExp = new byte[m_ulExpCnt][];
            m_pExpArr = new TASK_EXPRESSION[m_ulExpCnt];
            for (int i = 0; i < m_pszExp.Length; ++i)
            {
                m_pszExp[i] = br.ReadBytes(64);
                m_pExpArr[i] = TASK_EXPRESSION.Read(br);
            }

            m_pTaskChar = new byte[m_ulTaskCharCnt][];
            for (int i = 0; i < m_pTaskChar.Length; ++i)
                m_pTaskChar[i] = br.ReadBytes(128);

            m_Award_S = AWARD_DATA.Read(br, version);
            m_Award_F = AWARD_DATA.Read(br, version);
            m_AwByRatio_S = AWARD_RATIO_SCALE.Read(br, version);
            m_AwByRatio_F = AWARD_RATIO_SCALE.Read(br, version);
            m_AwByItems_S = AWARD_ITEMS_SCALE.Read(br, version);
            m_AwByItems_F = AWARD_ITEMS_SCALE.Read(br, version);

            conversation = new CONVERSATION();
            conversation.crypt_key = m_ID;
            conversation.prompt_character_count = br.ReadInt32();
            conversation.prompt_text = br.ReadBytes(conversation.prompt_character_count * 2);

            conversation.m_ulOkText = br.ReadInt32();
            conversation.m_pwstrOkText = br.ReadBytes(conversation.m_ulOkText * 2);

            conversation.m_ulNoText = br.ReadInt32();
            conversation.m_pwstrNoText = br.ReadBytes(conversation.m_ulNoText * 2);
            //conversation.seperator = br.ReadBytes(8); // да, своровал у рони, тогда ещё не знал структуру диалогов, но вот хз зачем рони пропускал тексты

            conversation.general_character_count = br.ReadInt32();
            conversation.general_text = br.ReadBytes(conversation.general_character_count * 2);
            conversation.dialogs = new DIALOG[5];
            for (int i = 0; i < conversation.dialogs.Length; ++i)
            {
                conversation.dialogs[i] = new DIALOG();
                conversation.dialogs[i].crypt_key = m_ID;
                conversation.dialogs[i].unknown = br.ReadInt32();
                conversation.dialogs[i].dialog_text = br.ReadBytes(128);
                conversation.dialogs[i].question_count = br.ReadInt32();
                conversation.dialogs[i].questions = new QUESTION[conversation.dialogs[i].question_count];
                for (int o = 0; o < conversation.dialogs[i].questions.Length; ++o)
                {
                    conversation.dialogs[i].questions[o] = new QUESTION();
                    conversation.dialogs[i].questions[o].crypt_key = m_ID;
                    conversation.dialogs[i].questions[o].question_id = br.ReadInt32();
                    conversation.dialogs[i].questions[o].previous_question = br.ReadInt32();
                    conversation.dialogs[i].questions[o].question_character_count = br.ReadInt32();
                    conversation.dialogs[i].questions[o].question_text = br.ReadBytes(conversation.dialogs[i].questions[o].question_character_count * 2);
                    conversation.dialogs[i].questions[o].answer_count = br.ReadInt32();
                    conversation.dialogs[i].questions[o].answers = new ANSWER[conversation.dialogs[i].questions[o].answer_count];
                    for (int p = 0; p < conversation.dialogs[i].questions[o].answer_count; ++p)
                    {
                        conversation.dialogs[i].questions[o].answers[p] = new ANSWER();
                        conversation.dialogs[i].questions[o].answers[p].crypt_key = m_ID;
                        conversation.dialogs[i].questions[o].answers[p].question_link = br.ReadInt32();
                        conversation.dialogs[i].questions[o].answers[p].answer_text = br.ReadBytes(128);
                        conversation.dialogs[i].questions[o].answers[p].task_link = br.ReadInt32();
                    }
                }
            }


                SubQuestsCount = br.ReadInt32();
                SubQuests = new ATaskTemplFixedData[SubQuestsCount];
                for (int i = 0; i < SubQuestsCount; i++)
                    SubQuests[i] = new ATaskTemplFixedData(br, version);
        }

        public void Write(BinaryWriter bw, int version)
        {
            bw.Write(m_ID);
            TasksExtensions.WriteTaskChar(bw,m_szName, 30, m_ID);
            bw.Write(m_bHasSign);
            bw.Write(pszSignaturePointer);
            bw.Write(m_ulType);
            bw.Write(m_ulTimeLimit);
            bw.Write(m_bOfflineFail);
            bw.Write(m_bAbsFail);
            task_tm.Write(bw, m_tmAbsFailTime);
            bw.Write(m_bItemNotTakeOff);
            bw.Write(m_bAbsTime);
            bw.Write(m_ulTimetable);
            bw.Write(m_tmType);
            bw.Write(tmStartPointer);
            bw.Write(tmEndPointer);
            bw.Write(m_lAvailFrequency);
            bw.Write(m_lPeriodLimit);
            bw.Write(m_bChooseOne);
            bw.Write(m_bRandOne);
            bw.Write(m_bExeChildInOrder);
            bw.Write(m_bParentAlsoFail);
            bw.Write(m_bParentAlsoSucc);
            bw.Write(m_bCanGiveUp);
            bw.Write(m_bCanRedo);
            bw.Write(m_bCanRedoAfterFailure);
            bw.Write(m_bClearAsGiveUp);
            bw.Write(m_bNeedRecord);
            bw.Write(m_bFailAsPlayerDie);
            bw.Write(m_ulMaxReceiver);
            bw.Write(m_bDelvInZone);
            bw.Write(m_ulDelvWorld);
            bw.Write(m_ulDelvRegionCnt);
            bw.Write(DelvRegionPointer);
            bw.Write(m_bEnterRegionFail);
            bw.Write(m_ulEnterRegionWorld);
            bw.Write(m_ulEnterRegionCnt);
            bw.Write(EnterRegionPointer);
            bw.Write(m_bLeaveRegionFail);
            bw.Write(m_ulLeaveRegionWorld);
            bw.Write(m_ulLeaveRegionCnt);
            bw.Write(LeaveRegionPointer);
            bw.Write(m_bLeaveForceFail);
            bw.Write(m_bTransTo);
            bw.Write(m_ulTransWldId);
            ZONE_VERT.Write(bw, m_TransPt);
            bw.Write(m_lMonsCtrl);
            bw.Write(m_bTrigCtrl);
            bw.Write(m_bAutoDeliver);
            if (version == 108)
                bw.Write(m_bPromptWhenAutoDeliver);
            if (version >= 118)
                bw.Write(m_bDisplayInExclusiveUI);
            bw.Write(m_bReadyToNotifyServer);
            if (version >= 118)
                bw.Write(m_bUsedInTokenShop);
            bw.Write(m_bDeathTrig);
            bw.Write(m_bClearAcquired);
            bw.Write(m_ulSuitableLevel);
            bw.Write(m_bShowPrompt);
            bw.Write(m_bKeyTask);
            bw.Write(m_ulDelvNPC);
            bw.Write(m_ulAwardNPC);
            bw.Write(m_bSkillTask);
            bw.Write(m_bCanSeekOut);
            bw.Write(m_bShowDirection);
            bw.Write(m_bMarriage);
            bw.Write(m_ulChangeKeyCnt);
            bw.Write(ChangeKeyPointer);
            bw.Write(ChangeKeyValuePointer);
            bw.Write(ChangeTypePointer);
            bw.Write(m_bSwitchSceneFail);
            bw.Write(m_bHidden);
            bw.Write(m_bDeliverySkill);
            bw.Write(m_iDeliveredSkillID);
            bw.Write(m_iDeliveredSkillLevel);
            bw.Write(m_bShowGfxFinished);
            bw.Write(m_bChangePQRanking);
            bw.Write(m_bCompareItemAndInventory);
            bw.Write(m_ulInventorySlotNum);
            bw.Write(m_bPQTask);
            bw.Write(m_ulPQExpCnt);
            bw.Write(PQExpPointer);
            bw.Write(PQExpArrPointer);
            bw.Write(m_bPQSubTask);
            bw.Write(m_bClearContrib);
            bw.Write(m_ulMonsterContribCnt);
            bw.Write(MonstersContribPointer);
            bw.Write(m_iPremNeedRecordTasksNum);
            bw.Write(m_bShowByNeedRecordTasksNum);
            bw.Write(m_iPremiseFactionContrib);
            bw.Write(m_bShowByFactionContrib);
            bw.Write(m_bAccountTaskLimit);
            if(version >= 118)
                bw.Write(m_bRoleTaskLimit);
            bw.Write(m_ulAccountTaskLimitCnt);
            bw.Write(m_bLeaveFactionFail);
            if (version >= 111)
                bw.Write(m_bNotIncCntWhenFailed);
            if (version >= 108)
                bw.Write(m_bNotClearItemWhenFailed);
            if (version >= 111)
                bw.Write(m_bDisplayInTitleTaskUI);
            bw.Write(m_ucPremiseTransformedForm);
            bw.Write(m_bShowByTransformed);
            bw.Write(m_ulPremise_Lev_Min);
            bw.Write(m_ulPremise_Lev_Max);
            if(version >= 118)
                bw.Write(m_bPremCheckMaxHistoryLevel);
            bw.Write(m_bShowByLev);
            if (version >= 118)
            {
                bw.Write(m_bPremCheckReincarnation);
                bw.Write(m_ulPremReincarnationMin);
                bw.Write(m_ulPremReincarnationMax);
                bw.Write(m_bShowByReincarnation);
                bw.Write(m_bPremCheckRealmLevel);
                bw.Write(m_ulPremRealmLevelMin);
                bw.Write(m_ulPremRealmLevelMax);
                bw.Write(m_bPremCheckRealmExpFull);
                bw.Write(m_bShowByRealmLevel);
            }
            bw.Write(m_ulPremItems);
            bw.Write(PremItemsPointer);
            bw.Write(m_bShowByItems);
            bw.Write(m_bPremItemsAnyOne);
            bw.Write(m_ulGivenItems);
            bw.Write(m_ulGivenCmnCount);
            bw.Write(m_ulGivenTskCount);
            bw.Write(GivenItemsPointer);
            bw.Write(m_ulPremise_Deposit);
            bw.Write(m_bShowByDeposit);
            bw.Write(m_lPremise_Reputation);
            bw.Write(m_lPremise_RepuMax);
            bw.Write(m_bShowByRepu);
            bw.Write(m_ulPremise_Task_Count);
            for (int i = 0; i < m_ulPremise_Tasks.Length; ++i)
                bw.Write(m_ulPremise_Tasks[i]);
            bw.Write(m_bShowByPreTask);
            bw.Write(m_ulPremise_Task_Least_Num);
            bw.Write(m_ulPremise_Period);
            bw.Write(m_bShowByPeriod);
            bw.Write(m_ulPremise_Faction);
            bw.Write(m_iPremise_FactionRole);
            bw.Write(m_bShowByFaction);
            bw.Write(m_ulGender);
            bw.Write(m_bShowByGender);
            bw.Write(m_ulOccupations);
            for (int i = 0; i < m_Occupations.Length; ++i)
                bw.Write(m_Occupations[i]);
            bw.Write(m_bShowByOccup);
            bw.Write(m_bPremise_Spouse);
            bw.Write(m_bShowBySpouse);
            bw.Write(m_bPremiseWeddingOwner);
            bw.Write(m_bShowByWeddingOwner);
            bw.Write(m_bGM);
            bw.Write(m_bShieldUser);
            bw.Write(m_bShowByRMB);
            bw.Write(m_ulPremRMBMin);
            bw.Write(m_ulPremRMBMax);
            bw.Write(m_bCharTime);
            bw.Write(m_bShowByCharTime);
            bw.Write(m_iCharStartTime);
            bw.Write(m_iCharEndTime);
            task_tm.Write(bw, m_tmCharEndTime);
            bw.Write(m_ulCharTimeGreaterThan);
            bw.Write(m_ulPremise_Cotask);
            bw.Write(m_ulCoTaskCond);
            bw.Write(m_ulMutexTaskCount);
            for (int i = 0; i < m_ulMutexTasks.Length; ++i)
                bw.Write(m_ulMutexTasks[i]);
            for (int i = 0; i < m_lSkillLev.Length; ++i)
                bw.Write(m_lSkillLev[i]);
            bw.Write(m_DynTaskType);
            bw.Write(m_ulSpecialAward);
            bw.Write(m_bTeamwork);
            bw.Write(m_bRcvByTeam);
            bw.Write(m_bSharedTask);
            bw.Write(m_bSharedAchieved);
            bw.Write(m_bCheckTeammate);
            bw.Write(m_fTeammateDist);
            bw.Write(m_bAllFail);
            bw.Write(m_bCapFail);
            bw.Write(m_bCapSucc);
            bw.Write(m_fSuccDist);
            bw.Write(m_bDismAsSelfFail);
            bw.Write(m_bRcvChckMem);
            bw.Write(m_fRcvMemDist);
            bw.Write(m_bCntByMemPos);
            bw.Write(m_fCntMemDist);
            bw.Write(m_bAllSucc);
            bw.Write(m_bCoupleOnly);
            bw.Write(m_bDistinguishedOcc);
            bw.Write(m_ulTeamMemsWanted);
            bw.Write(TeamMemsWantedPointer);
            bw.Write(m_bShowByTeam);
            bw.Write(m_bPremNeedComp);
            bw.Write(m_nPremExp1AndOrExp2);
            COMPARE_KEY_VALUE.Write(bw, m_Prem1KeyValue);
            COMPARE_KEY_VALUE.Write(bw, m_Prem2KeyValue);
            bw.Write(m_bPremCheckForce);
            bw.Write(m_iPremForce);
            bw.Write(m_bShowByForce);
            bw.Write(m_iPremForceReputation);
            bw.Write(m_bShowByForceReputation);
            bw.Write(m_iPremForceContribution);
            bw.Write(m_bShowByForceContribution);
            bw.Write(m_iPremForceExp);
            bw.Write(m_bShowByForceExp);
            bw.Write(m_iPremForceSP);
            bw.Write(m_bShowByForceSP);
            bw.Write(m_iPremForceActivityLevel);
            bw.Write(m_bShowByForceActivityLevel);
            if (version >= 108)
            {
                bw.Write(m_bPremIsKing);
                bw.Write(m_bShowByKing);
                bw.Write(m_bPremNotInTeam);
                bw.Write(m_bShowByNotInTeam);
            }
            if (version >= 111)
            {
                bw.Write(m_iPremTitleNumTotal);
                bw.Write(m_iPremTitleNumRequired);
                bw.Write(PremTitlesPointer);
                bw.Write(m_bShowByTitle);
            }
            if (version >= 118)
            {
                for (int i = 0; i < m_iPremHistoryStageIndex.Length; ++i)
                    bw.Write(m_iPremHistoryStageIndex[i]);
                bw.Write(m_bShowByHistoryStage);
                bw.Write(m_ulPremGeneralCardCount);
                bw.Write(m_bShowByGeneralCard);
                bw.Write(m_iPremGeneralCardRank);
                bw.Write(m_ulPremGeneralCardRankCount);
                bw.Write(m_bShowByGeneralCardRank);
            }
            bw.Write(m_enumMethod);
            bw.Write(m_enumFinishType);
            bw.Write(m_ulPlayerWanted);
            bw.Write(PlayerWantedPointer);
            bw.Write(m_ulMonsterWanted);
            bw.Write(MonsterWantedPointer);
            bw.Write(m_ulItemsWanted);
            bw.Write(ItemsWantedPointer);
            bw.Write(m_ulGoldWanted);
            bw.Write(m_iFactionContribWanted);
            bw.Write(m_iFactionExpContribWanted);
            bw.Write(m_ulNPCToProtect);
            bw.Write(m_ulProtectTimeLen);
            bw.Write(m_ulNPCMoving);
            bw.Write(m_ulNPCDestSite);
            bw.Write(ReachSitePointer);
            bw.Write(m_ulReachSiteCnt);
            bw.Write(m_ulReachSiteId);
            bw.Write(m_ulWaitTime);
            ZONE_VERT.Write(bw, m_TreasureStartZone);
            bw.Write(m_ucZonesNumX);
            bw.Write(m_ucZonesNumZ);
            bw.Write(m_ucZoneSide);
            bw.Write(LeaveSitePointer);
            bw.Write(m_ulLeaveSiteCnt);
            bw.Write(m_ulLeaveSiteId);
            bw.Write(m_bFinNeedComp);
            bw.Write(m_nFinExp1AndOrExp2);
            COMPARE_KEY_VALUE.Write(bw, m_Fin1KeyValue);
            COMPARE_KEY_VALUE.Write(bw, m_Fin2KeyValue);
            bw.Write(m_ulExpCnt);
            bw.Write(pszExpPointer);
            bw.Write(ExpArrPointer);
            bw.Write(m_ulTaskCharCnt);
            bw.Write(TaskCharPointer);
            bw.Write(m_ucTransformedForm);
            if (version >= 118)
            {
                bw.Write(m_ulReachLevel);
                bw.Write(m_ulReachReincarnationCount);
                bw.Write(m_ulReachRealmLevel);
                bw.Write(m_uiEmotion);
            }
            bw.Write(m_ulAwardType_S);
            bw.Write(m_ulAwardType_F);
            bw.Write(Award_S_Pointer);
            bw.Write(Award_F_Pointer);
            bw.Write(AwByRatio_S_Pointer);
            bw.Write(AwByRatio_F_Pointer);
            bw.Write(AwByItems_S_Pointer);
            bw.Write(AwByItems_F_Pointer);
            bw.Write(m_ulParent);
            bw.Write(m_ulPrevSibling);
            bw.Write(m_ulNextSibling);
            bw.Write(m_ulFirstChild);
            bw.Write(m_bIsLibraryTask);
            bw.Write(m_fLibraryTasksProbability);
            bw.Write(m_bIsUniqueStorageTask);

            if (m_bHasSign)
				TasksExtensions.WriteTaskChar(bw,m_pszSignature, 30, m_ID);
            for (int i = 0; i < m_tmStart.Length; ++i)
            {
                task_tm.Write(bw, m_tmStart[i]);
                task_tm.Write(bw, m_tmEnd[i]);
            }
            for (int i = 0; i < m_pDelvRegion.Length; ++i)
                Task_Region.Write(bw, m_pDelvRegion[i]);
            for (int i = 0; i < m_pEnterRegion.Length; ++i)
                Task_Region.Write(bw, m_pEnterRegion[i]);
            for (int i = 0; i < m_pLeaveRegion.Length; ++i)
                Task_Region.Write(bw, m_pLeaveRegion[i]);
            for (int i = 0; i < m_plChangeKey.Length; ++i)
            {
                bw.Write(m_plChangeKey[i]);
                bw.Write(m_plChangeKeyValue[i]);
                bw.Write(m_pbChangeType[i]);
            }
            for (int i = 0; i < m_pszPQExp.Length; ++i)
            {
                bw.Write(m_pszPQExp[i]);
                TASK_EXPRESSION.Write(bw, m_pPQExpArr[i]);
            }
            for (int i = 0; i < m_MonstersContrib.Length; ++i)
                MONSTERS_CONTRIB.Write(bw, m_MonstersContrib[i]);
            for (int i = 0; i < m_PremItems.Length; ++i)
                ITEM_WANTED.Write(bw, m_PremItems[i]);
            for (int i = 0; i < m_GivenItems.Length; ++i)
                ITEM_WANTED.Write(bw, m_GivenItems[i]);
            for (int i = 0; i < m_TeamMemsWanted.Length; ++i)
                TEAM_MEM_WANTED.Write(bw, m_TeamMemsWanted[i]);
            for (int i = 0; i < m_PremTitles.Length; ++i)
                bw.Write(m_PremTitles[i]);
            for (int i = 0; i < m_PlayerWanted.Length; ++i)
                PLAYER_WANTED.Write(bw, m_PlayerWanted[i]);
            for (int i = 0; i < m_MonsterWanted.Length; ++i)
                MONSTER_WANTED.Write(bw, m_MonsterWanted[i]);
            for (int i = 0; i < m_ItemsWanted.Length; ++i)
                ITEM_WANTED.Write(bw, m_ItemsWanted[i]);
            for (int i = 0; i < m_pReachSite.Length; ++i)
                Task_Region.Write(bw, m_pReachSite[i]);
            for (int i = 0; i < m_pLeaveSite.Length; ++i)
                Task_Region.Write(bw, m_pLeaveSite[i]);
            for (int i = 0; i < m_pszExp.Length; ++i)
            {
                bw.Write(m_pszExp[i]);
                TASK_EXPRESSION.Write(bw, m_pExpArr[i]);
            }
            for (int i = 0; i < m_pTaskChar.Length; ++i)
                bw.Write(m_pTaskChar[i]);

            AWARD_DATA.Write(bw, version, m_Award_S);
            AWARD_DATA.Write(bw, version, m_Award_F);
            AWARD_RATIO_SCALE.Write(bw, version, m_AwByRatio_S);
            AWARD_RATIO_SCALE.Write(bw, version, m_AwByRatio_F);
            AWARD_ITEMS_SCALE.Write(bw, version, m_AwByItems_S);
            AWARD_ITEMS_SCALE.Write(bw, version, m_AwByItems_F);

            bw.Write(conversation.prompt_character_count);
            bw.Write(conversation.prompt_text);

            bw.Write(conversation.m_ulOkText);
            bw.Write(conversation.m_pwstrOkText);

            bw.Write(conversation.m_ulNoText);
            bw.Write(conversation.m_pwstrNoText);

            bw.Write(conversation.general_character_count);
            bw.Write(conversation.general_text);
            for (int d = 0; d < conversation.dialogs.Length; d++)
            {
                bw.Write(conversation.dialogs[d].unknown);
                bw.Write(conversation.dialogs[d].dialog_text);
                bw.Write(conversation.dialogs[d].question_count);
                for (int q = 0; q < conversation.dialogs[d].questions.Length; q++)
                {
                    bw.Write(conversation.dialogs[d].questions[q].question_id);
                    bw.Write(conversation.dialogs[d].questions[q].previous_question);
                    bw.Write(conversation.dialogs[d].questions[q].question_character_count);
                    bw.Write(conversation.dialogs[d].questions[q].question_text);
                    bw.Write(conversation.dialogs[d].questions[q].answer_count);
                    for (int a = 0; a < conversation.dialogs[d].questions[q].answer_count; a++)
                    {
                        bw.Write(conversation.dialogs[d].questions[q].answers[a].question_link);
                        bw.Write(conversation.dialogs[d].questions[q].answers[a].answer_text);
                        bw.Write(conversation.dialogs[d].questions[q].answers[a].task_link);
                    }
                }
            }
            bw.Write(SubQuestsCount);
            for (int i = 0; i < SubQuestsCount; i++)
                SubQuests[i].Write(bw, version);
        }

        public ATaskTemplFixedData Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryReader br = new BinaryReader(ms);
            BinaryWriter bw = new BinaryWriter(ms);

            Write(bw, 9999);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            ATaskTemplFixedData quest = new ATaskTemplFixedData(br, 9999);

            bw.Close();
            br.Close();
            ms.Close();

            return quest;
        }
    }
}