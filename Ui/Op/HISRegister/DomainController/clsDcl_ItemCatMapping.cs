using System;
using weCare.Core.Entity;
using System.Data;

namespace com.digitalwave.iCare.gui.HIS
{
    /// <summary>
    /// clsDcl_ItemCatMapping 的摘要说明。
    /// </summary>
    public class clsDcl_ItemCatMapping : com.digitalwave.GUI_Base.clsDomainController_Base
    {
        public clsDcl_ItemCatMapping()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region GetProxy 
        /// <summary>
        /// GetProxy
        /// </summary>
        weCare.Proxy.ProxyOP proxy
        {
            get
            {
                return new weCare.Proxy.ProxyOP();
            }
        }
        #endregion 

        #region 加载主listview的选项
        public long m_mthLoadMainListViewItem(out clsChargeItemEXType_VO[] p_objResultArr)
        {
            long lngRes = 0;
            //com.digitalwave.iCare.middletier.HIS.clsChargeItemSvc objSvc =
            //    (com.digitalwave.iCare.middletier.HIS.clsChargeItemSvc)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsChargeItemSvc));
            lngRes = proxy.Service.m_lngFindChargeItemEXTypeListByFlag("2", out p_objResultArr);
            //objSvc.Dispose();
            return lngRes;

        }
        #endregion
        #region 获得隶属分类
        public long m_mthGetSubjectionCat(out DataTable dt, string strCatID, int flag)
        {
            dt = null;
            long lngRes = 0;
            //com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc objSvc =
            //    (com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc));
            lngRes = proxy.Service.m_mthGetSubjectionCat(out dt, strCatID, flag);
            //objSvc.Dispose();
            return lngRes;

        }
        #endregion
        #region 保存数据
        public long m_mthSaveData(clsItemCatMapping_VO[] ICM_VO, string strCatID, int flag)
        {
            long lngRes = 0;
            //com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc objSvc =
            //    (com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc));
            lngRes = proxy.Service.m_mthSaveData(ICM_VO, strCatID, flag);
            //objSvc.Dispose();
            return lngRes;
        }
        #endregion
        #region 查询药房信息
        public long m_mthMedstoreInfo(out DataTable dt, string strExpen)
        {
            dt = null;
            long lngRes = 0;
            //com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc objSvc =
            //    (com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc));
            lngRes = proxy.Service.m_mthMedstoreInfo(out dt, strExpen);
            //objSvc.Dispose();
            return lngRes;
        }

        #endregion
        #region 根据药房ID查出窗口
        public long m_mthWindowInfoByID(out DataTable dt, string strExpen)
        {
            dt = null;
            long lngRes = 0;
            //com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc objSvc =
            //    (com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc)com.digitalwave.iCare.common.clsObjectGenerator.objCreatorObjectByType(typeof(com.digitalwave.iCare.middletier.HIS.clsItemCatMappingSvc));
            lngRes = proxy.Service.m_mthWindowInfoByID(out dt, strExpen);
            //objSvc.Dispose();
            return lngRes;
        }

        #endregion
    }
}
