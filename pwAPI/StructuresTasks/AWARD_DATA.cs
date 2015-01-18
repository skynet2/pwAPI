using System;
using System.IO;

namespace JQEditor.Classes
{
    public class AWARD_DATA
    {
        public int m_ulGoldNum;
        public int m_ulExp;
        public int m_ulRealmExp;
        public bool m_bExpandRealmLevelMax;
        public int m_ulNewTask;
        public int m_ulSP;
        public int m_lReputation;
        public int m_ulNewPeriod;
        public int m_ulNewRelayStation;
        public int m_ulStorehouseSize;
        public int m_ulStorehouseSize2;
        public int m_ulStorehouseSize3;
        public int m_ulStorehouseSize4;
        public int m_lInventorySize;
        public int m_ulPetInventorySize;
        public int m_ulFuryULimit;
        public int m_ulTransWldId;
        public ZONE_VERT m_TransPt;
        public int m_lMonsCtrl;
        public bool m_bTrigCtrl;
        public bool m_bUseLevCo;
        public bool m_bDivorce;
        public bool m_bSendMsg;
        public int m_nMsgChannel;
        public int m_ulCandItems;
        public AWARD_ITEMS_CAND[] m_CandItems;
        public int m_ulSummonedMonsters;
        public AWARD_MONSTERS_SUMMONED[] m_SummonedMonsters;
        public bool m_bAwardDeath;
        public bool m_bAwardDeathWithLoss;
        public int m_ulDividend;
        public bool m_bAwardSkill;
        public int m_iAwardSkillID;
        public int m_iAwardSkillLevel;
        public int m_ulSpecifyContribTaskID;
        public int m_ulSpecifyContribSubTaskID;
        public int m_ulSpecifyContrib;
        public int m_ulContrib;
        public int m_ulRandContrib;
        public int m_ulLowestcontrib;
        public int m_iFactionContrib;
        public int m_iFactionExpContrib;
        public int m_ulPQRankingAwardCnt;
        public AWARD_PQ_RANKING[] m_PQRankingAward;
        public int m_ulChangeKeyCnt;
        public int[] m_plChangeKey;
        public int[] m_plChangeKeyValue;
        public bool[] m_pbChangeType;
        public int m_ulHistoryChangeCnt;
        public int[] m_plHistoryChangeKey;
        public int[] m_plHistoryChangeKeyValue;
        public bool[] m_pbHistoryChangeType;
        public bool m_bMulti;
        public int m_nNumType;
        public int m_lNum;
        public int m_ulDisplayKeyCnt;
        public int[] m_plDisplayKey;
        public int m_ulExpCnt;
        public byte[][] m_pszExp;
        public TASK_EXPRESSION[] m_pExpArr;
        public int m_ulTaskCharCnt;
        public byte[][] m_pTaskChar;
        public int m_iForceContribution;
        public int m_iForceReputation;
        public int m_iForceActivity;
        public int m_iForceSetRepu;
        public int m_iTaskLimit;
        public int m_ulTitleNum;
        public TITLE_AWARD[] m_pTitleAward;
        public int m_iLeaderShip;

        public int CandItemsPointer, SummonedMonstersPointer, PQRankingAwardPointer, ChangeKeyPointer, ChangeKeyValuePointer,
            ChangeTypePointer, HistoryChangeKeyPointer, HistoryChangeKeyValuePointer, HistoryChangeTypePointer,
            DisplayKeyPointer, pszExpPointer, ExpArrPointer, TaskCharPointer, TitleAwardPointer;

        internal static AWARD_DATA Read(BinaryReader br, int version)
        {
            AWARD_DATA reader = new AWARD_DATA();
            reader.m_ulGoldNum = br.ReadInt32();
            reader.m_ulExp = br.ReadInt32();
            if (version >= 118)
            {
                reader.m_ulRealmExp = br.ReadInt32();
                reader.m_bExpandRealmLevelMax = br.ReadBoolean();
            }
            reader.m_ulNewTask = br.ReadInt32();
            reader.m_ulSP = br.ReadInt32();
            reader.m_lReputation = br.ReadInt32();
            reader.m_ulNewPeriod = br.ReadInt32();
            reader.m_ulNewRelayStation = br.ReadInt32();
            reader.m_ulStorehouseSize = br.ReadInt32();
            reader.m_ulStorehouseSize2 = br.ReadInt32();
            reader.m_ulStorehouseSize3 = br.ReadInt32();
            reader.m_ulStorehouseSize4 = br.ReadInt32();
            reader.m_lInventorySize = br.ReadInt32();
            reader.m_ulPetInventorySize = br.ReadInt32();
            reader.m_ulFuryULimit = br.ReadInt32();
            reader.m_ulTransWldId = br.ReadInt32();
            reader.m_TransPt = ZONE_VERT.Read(br);
            reader.m_lMonsCtrl = br.ReadInt32();
            reader.m_bTrigCtrl = br.ReadBoolean();
            reader.m_bUseLevCo = br.ReadBoolean();
            reader.m_bDivorce = br.ReadBoolean();
            reader.m_bSendMsg = br.ReadBoolean();
            reader.m_nMsgChannel = br.ReadInt32();
            reader.m_ulCandItems = br.ReadInt32();
            reader.CandItemsPointer = br.ReadInt32();
            reader.m_ulSummonedMonsters = br.ReadInt32();
            reader.SummonedMonstersPointer = br.ReadInt32();
            reader.m_bAwardDeath = br.ReadBoolean();
            reader.m_bAwardDeathWithLoss = br.ReadBoolean();
            reader.m_ulDividend = br.ReadInt32();
            reader.m_bAwardSkill = br.ReadBoolean();
            reader.m_iAwardSkillID = br.ReadInt32();
            reader.m_iAwardSkillLevel = br.ReadInt32();
            reader.m_ulSpecifyContribTaskID = br.ReadInt32();
            reader.m_ulSpecifyContribSubTaskID = br.ReadInt32();
            reader.m_ulSpecifyContrib = br.ReadInt32();
            reader.m_ulContrib = br.ReadInt32();
            reader.m_ulRandContrib = br.ReadInt32();
            reader.m_ulLowestcontrib = br.ReadInt32();
            reader.m_iFactionContrib = br.ReadInt32();
            reader.m_iFactionExpContrib = br.ReadInt32();
            reader.m_ulPQRankingAwardCnt = br.ReadInt32();
            reader.PQRankingAwardPointer = br.ReadInt32();
            reader.m_ulChangeKeyCnt = br.ReadInt32();
            reader.ChangeKeyPointer = br.ReadInt32();
            reader.ChangeKeyValuePointer = br.ReadInt32();
            reader.ChangeTypePointer = br.ReadInt32();
            if (version >= 118)
            {
                reader.m_ulHistoryChangeCnt = br.ReadInt32();
                reader.HistoryChangeKeyPointer = br.ReadInt32();
                reader.HistoryChangeKeyValuePointer = br.ReadInt32();
                reader.HistoryChangeTypePointer = br.ReadInt32();
            }
            reader.m_bMulti = br.ReadBoolean();
            reader.m_nNumType = br.ReadInt32();
            reader.m_lNum = br.ReadInt32();
            reader.m_ulDisplayKeyCnt = br.ReadInt32();
            reader.DisplayKeyPointer = br.ReadInt32();
            reader.m_ulExpCnt = br.ReadInt32();
            reader.pszExpPointer = br.ReadInt32();
            reader.ExpArrPointer = br.ReadInt32();
            reader.m_ulTaskCharCnt = br.ReadInt32();
            reader.TaskCharPointer = br.ReadInt32();
            reader.m_iForceContribution = br.ReadInt32();
            reader.m_iForceReputation = br.ReadInt32();
            reader.m_iForceActivity = br.ReadInt32();
            reader.m_iForceSetRepu = br.ReadInt32();
            reader.m_iTaskLimit = br.ReadInt32();
            if (version >= 111)
            {
                reader.m_ulTitleNum = br.ReadInt32();
                reader.TitleAwardPointer = br.ReadInt32();
            }
            if (version >= 118)
                reader.m_iLeaderShip = br.ReadInt32();

            reader.m_CandItems = new AWARD_ITEMS_CAND[reader.m_ulCandItems];
            for (int i = 0; i < reader.m_CandItems.Length; ++i)
                reader.m_CandItems[i] = AWARD_ITEMS_CAND.Read(br);

            if (reader.m_ulSummonedMonsters > 0)
            {
                reader.m_SummonedMonsters = new AWARD_MONSTERS_SUMMONED[1];
                reader.m_SummonedMonsters[0] = AWARD_MONSTERS_SUMMONED.Read(br, reader.m_ulSummonedMonsters);
            }

            if (reader.m_ulPQRankingAwardCnt > 0)
            {
                reader.m_PQRankingAward = new AWARD_PQ_RANKING[1];
                reader.m_PQRankingAward[0] = AWARD_PQ_RANKING.Read(br, reader.m_ulPQRankingAwardCnt);
            }

            reader.m_plChangeKey = new int[reader.m_ulChangeKeyCnt];
            reader.m_plChangeKeyValue = new int[reader.m_ulChangeKeyCnt];
            reader.m_pbChangeType = new bool[reader.m_ulChangeKeyCnt];
            for (int i = 0; i < reader.m_plChangeKey.Length; ++i)
            {
                reader.m_plChangeKey[i] = br.ReadInt32();
                reader.m_plChangeKeyValue[i] = br.ReadInt32();
                reader.m_pbChangeType[i] = br.ReadBoolean();
            }
            if (version >= 118)
            {
                reader.m_plHistoryChangeKey = new int[reader.m_ulHistoryChangeCnt];
                reader.m_plHistoryChangeKeyValue = new int[reader.m_ulHistoryChangeCnt];
                reader.m_pbHistoryChangeType = new bool[reader.m_ulHistoryChangeCnt];
                for (int i = 0; i < reader.m_plHistoryChangeKey.Length; ++i)
                {
                    reader.m_plHistoryChangeKey[i] = br.ReadInt32();
                    reader.m_plHistoryChangeKeyValue[i] = br.ReadInt32();
                    reader.m_pbHistoryChangeType[i] = br.ReadBoolean();
                }
            }
            reader.m_plDisplayKey = new int[reader.m_ulDisplayKeyCnt];
            for (int i = 0; i < reader.m_plDisplayKey.Length; ++i)
                reader.m_plDisplayKey[i] = br.ReadInt32();

            reader.m_pszExp = new byte[reader.m_ulExpCnt][];
            reader.m_pExpArr = new TASK_EXPRESSION[reader.m_ulExpCnt];
            for (int i = 0; i < reader.m_pszExp.Length; ++i)
            {
                reader.m_pszExp[i] = br.ReadBytes(64);
                reader.m_pExpArr[i] = TASK_EXPRESSION.Read(br);
            }

            reader.m_pTaskChar = new byte[reader.m_ulTaskCharCnt][];
            for (int i = 0; i < reader.m_pTaskChar.Length; ++i)
                reader.m_pTaskChar[i] = br.ReadBytes(128);

            if (version >= 111)
            {
                reader.m_pTitleAward = new TITLE_AWARD[reader.m_ulTitleNum];
                for (int i = 0; i < reader.m_pTitleAward.Length; ++i)
                    reader.m_pTitleAward[i] = TITLE_AWARD.Read(br);
            }

            return reader;
        }

        internal static void Write(BinaryWriter bw, int version, AWARD_DATA writer)
        {
            bw.Write(writer.m_ulGoldNum);
            bw.Write(writer.m_ulExp);
            if (version >= 118)
            {
                bw.Write(writer.m_ulRealmExp);
                bw.Write(writer.m_bExpandRealmLevelMax);
            }
            bw.Write(writer.m_ulNewTask);
            bw.Write(writer.m_ulSP);
            bw.Write(writer.m_lReputation);
            bw.Write(writer.m_ulNewPeriod);
            bw.Write(writer.m_ulNewRelayStation);
            bw.Write(writer.m_ulStorehouseSize);
            bw.Write(writer.m_ulStorehouseSize2);
            bw.Write(writer.m_ulStorehouseSize3);
            bw.Write(writer.m_ulStorehouseSize4);
            bw.Write(writer.m_lInventorySize);
            bw.Write(writer.m_ulPetInventorySize);
            bw.Write(writer.m_ulFuryULimit);
            bw.Write(writer.m_ulTransWldId);
            ZONE_VERT.Write(bw, writer.m_TransPt);
            bw.Write(writer.m_lMonsCtrl);
            bw.Write(writer.m_bTrigCtrl);
            bw.Write(writer.m_bUseLevCo);
            bw.Write(writer.m_bDivorce);
            bw.Write(writer.m_bSendMsg);
            bw.Write(writer.m_nMsgChannel);
            bw.Write(writer.m_ulCandItems);
            bw.Write(writer.CandItemsPointer);
            bw.Write(writer.m_ulSummonedMonsters);
            bw.Write(writer.SummonedMonstersPointer);
            bw.Write(writer.m_bAwardDeath);
            bw.Write(writer.m_bAwardDeathWithLoss);
            bw.Write(writer.m_ulDividend);
            bw.Write(writer.m_bAwardSkill);
            bw.Write(writer.m_iAwardSkillID);
            bw.Write(writer.m_iAwardSkillLevel);
            bw.Write(writer.m_ulSpecifyContribTaskID);
            bw.Write(writer.m_ulSpecifyContribSubTaskID);
            bw.Write(writer.m_ulSpecifyContrib);
            bw.Write(writer.m_ulContrib);
            bw.Write(writer.m_ulRandContrib);
            bw.Write(writer.m_ulLowestcontrib);
            bw.Write(writer.m_iFactionContrib);
            bw.Write(writer.m_iFactionExpContrib);
            bw.Write(writer.m_ulPQRankingAwardCnt);
            bw.Write(writer.PQRankingAwardPointer);
            bw.Write(writer.m_ulChangeKeyCnt);
            bw.Write(writer.ChangeKeyPointer);
            bw.Write(writer.ChangeKeyValuePointer);
            bw.Write(writer.ChangeTypePointer);
            if (version >= 118)
            {
                bw.Write(writer.m_ulHistoryChangeCnt);
                bw.Write(writer.HistoryChangeKeyPointer);
                bw.Write(writer.HistoryChangeKeyValuePointer);
                bw.Write(writer.HistoryChangeTypePointer);
            }
            bw.Write(writer.m_bMulti);
            bw.Write(writer.m_nNumType);
            bw.Write(writer.m_lNum);
            bw.Write(writer.m_ulDisplayKeyCnt);
            bw.Write(writer.DisplayKeyPointer);
            bw.Write(writer.m_ulExpCnt);
            bw.Write(writer.pszExpPointer);
            bw.Write(writer.ExpArrPointer);
            bw.Write(writer.m_ulTaskCharCnt);
            bw.Write(writer.TaskCharPointer);
            bw.Write(writer.m_iForceContribution);
            bw.Write(writer.m_iForceReputation);
            bw.Write(writer.m_iForceActivity);
            bw.Write(writer.m_iForceSetRepu);
            bw.Write(writer.m_iTaskLimit);
            if (version >= 111)
            {
                bw.Write(writer.m_ulTitleNum);
                bw.Write(writer.TitleAwardPointer);
            }
            if (version >= 118)
                bw.Write(writer.m_iLeaderShip);

            for (int i = 0; i < writer.m_CandItems.Length; ++i)
                AWARD_ITEMS_CAND.Write(bw, writer.m_CandItems[i]);
            if (writer.m_ulSummonedMonsters > 0)
                AWARD_MONSTERS_SUMMONED.Write(bw, writer.m_SummonedMonsters[0]);
            if (writer.m_ulPQRankingAwardCnt > 0)
                AWARD_PQ_RANKING.Write(bw, writer.m_PQRankingAward[0]);
            for (int i = 0; i < writer.m_plChangeKey.Length; ++i)
            {
                bw.Write(writer.m_plChangeKey[i]);
                bw.Write(writer.m_plChangeKeyValue[i]);
                bw.Write(writer.m_pbChangeType[i]);
            }
            if (version >= 118)
            {
                for (int i = 0; i < writer.m_plHistoryChangeKey.Length; ++i)
                {
                    bw.Write(writer.m_plHistoryChangeKey[i]);
                    bw.Write(writer.m_plHistoryChangeKeyValue[i]);
                    bw.Write(writer.m_pbHistoryChangeType[i]);
                }
            }
            for (int i = 0; i < writer.m_plDisplayKey.Length; ++i)
                bw.Write(writer.m_plDisplayKey[i]);
            for (int i = 0; i < writer.m_pszExp.Length; ++i)
            {
                bw.Write(writer.m_pszExp[i]);
                TASK_EXPRESSION.Write(bw, writer.m_pExpArr[i]);
            }
            for (int i = 0; i < writer.m_pTaskChar.Length; ++i)
                bw.Write(writer.m_pTaskChar[i]);
            if (version >= 111)
            {
                for (int i = 0; i < writer.m_pTitleAward.Length; ++i)
                    TITLE_AWARD.Write(bw, writer.m_pTitleAward[i]);
            }
        }
    }
}