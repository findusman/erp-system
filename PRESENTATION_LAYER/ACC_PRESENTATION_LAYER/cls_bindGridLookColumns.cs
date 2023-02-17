using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER
{
    class cls_bindGridLookColumns
    {


          public static bool TBL_COA(GridColumn pGridColumn , string pStatus , string pDisplayMember )
          {


                RepositoryItemGridLookUpEdit objRepositoryItemGridLookUpEdit = new RepositoryItemGridLookUpEdit();

                if (pStatus == "L_Type_Transaction_Active")
                {
                      ACC_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_COA_FinancialAndTransaction(objRepositoryItemGridLookUpEdit,pDisplayMember);
                      pGridColumn.ColumnEdit = objRepositoryItemGridLookUpEdit;
                }
                      return true;
          
          }  


       

    }
}
