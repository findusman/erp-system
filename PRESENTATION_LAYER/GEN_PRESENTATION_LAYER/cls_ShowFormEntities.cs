using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER
{
    public class cls_ShowFormEntities
    {



          public static string TBL_RIGHTS_MAIN(string pID, string pRIGHTS_MAIN_rightAssigner, bool isParent, bool isUnique, bool isDisturbed)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN));

                GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN obj_TBL_RIGHTS_MAIN = new GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN(pID, pRIGHTS_MAIN_rightAssigner,isDisturbed);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_RIGHTS_MAIN.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_RIGHTS_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_RIGHTS_MAIN.Show();

                            }
                            else
                            {

                                  obj_TBL_RIGHTS_MAIN.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_RIGHTS_MAIN.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }


          //public static string TBL_RIGHTS_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed)
          //{

          //      bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN));

          //      GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN obj_TBL_RIGHTS_MAIN = new GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN(pID, isDisturbed);
          //      bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_RIGHTS_MAIN.Name, "G");
          //      if (isOk)
          //      {
          //            if (isParent)
          //            {
          //                  obj_TBL_RIGHTS_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
          //                  if (isUnique)
          //                  {

          //                        if (!isFormOpen)
          //                              obj_TBL_RIGHTS_MAIN.Show();

          //                  }
          //                  else
          //                  {

          //                        obj_TBL_RIGHTS_MAIN.Show();
          //                  }
          //            }
          //            else
          //            {
          //                  obj_TBL_RIGHTS_MAIN.ShowDialog();
          //            }
          //            return "ok";

          //      }
          //      else
          //      {
          //            GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

          //            return objcls_MessageBox.error_notAllowedToOpenScreen;
          //      }
          //}



          public static string TBL_CMP(string pID, bool isParent, bool isUnique, bool isDisturbed)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_CMP.frm_TBL_CMP));

                GEN_PRESENTATION_LAYER.Forms.TBL_CMP.frm_TBL_CMP obj_TBL_CMP = new GEN_PRESENTATION_LAYER.Forms.TBL_CMP.frm_TBL_CMP(pID, isDisturbed);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_CMP.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_CMP.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_CMP.Show();

                            }
                            else
                            {

                                  obj_TBL_CMP.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_CMP.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }

public static string TBL_BRC(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_BRC.frm_TBL_BRC));

            GEN_PRESENTATION_LAYER.Forms.TBL_BRC.frm_TBL_BRC obj_TBL_BRC = new GEN_PRESENTATION_LAYER.Forms.TBL_BRC.frm_TBL_BRC(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_BRC.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_BRC.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_BRC.Show();

                    }
                    else
                    {

                        obj_TBL_BRC.Show();
                    }
                }
                else
                {
                    obj_TBL_BRC.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }

          public static string TBL_USERS(string pID, bool isParent, bool isUnique, bool isDisturbed)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_USERS.frm_TBL_USERS));

                GEN_PRESENTATION_LAYER.Forms.TBL_USERS.frm_TBL_USERS obj_TBL_USERS = new GEN_PRESENTATION_LAYER.Forms.TBL_USERS.frm_TBL_USERS(pID, isDisturbed);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_USERS.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_USERS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_USERS.Show();

                            }
                            else
                            {

                                  obj_TBL_USERS.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_USERS.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }

          //public static string TBL_RIGHTS_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed)
          //{

          //      bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN));

          //      GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN obj_TBL_RIGHTS_MAIN = new GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN.frm_TBL_RIGHTS_MAIN(pID, isDisturbed);
          //      bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_RIGHTS_MAIN.Name, "G");
          //      if (isOk)
          //      {
          //            if (isParent)
          //            {
          //                  obj_TBL_RIGHTS_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
          //                  if (isUnique)
          //                  {

          //                        if (!isFormOpen)
          //                              obj_TBL_RIGHTS_MAIN.Show();

          //                  }
          //                  else
          //                  {

          //                        obj_TBL_RIGHTS_MAIN.Show();
          //                  }
          //            }
          //            else
          //            {
          //                  obj_TBL_RIGHTS_MAIN.ShowDialog();
          //            }
          //            return "ok";

          //      }
          //      else
          //      {
          //            GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

          //            return objcls_MessageBox.error_notAllowedToOpenScreen;
          //      }
          //}


          public static string TBL_RIGHTS_TEMPLATE(string pID, bool isParent, bool isUnique, bool isDisturbed)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_TEMPLATE.frm_TBL_RIGHTS_TEMPLATE));

                GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_TEMPLATE.frm_TBL_RIGHTS_TEMPLATE obj_TBL_RIGHTS_TEMPLATE = new GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_TEMPLATE.frm_TBL_RIGHTS_TEMPLATE(pID, isDisturbed);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_RIGHTS_TEMPLATE.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_RIGHTS_TEMPLATE.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_RIGHTS_TEMPLATE.Show();

                            }
                            else
                            {

                                  obj_TBL_RIGHTS_TEMPLATE.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_RIGHTS_TEMPLATE.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }


                public static string TBL_TEMP_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed)
                {

                            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_TEMP_MAIN.frm_TBL_TEMP_MAIN));

                            GEN_PRESENTATION_LAYER.Forms.TBL_TEMP_MAIN.frm_TBL_TEMP_MAIN obj_TBL_TEMP_MAIN = new GEN_PRESENTATION_LAYER.Forms.TBL_TEMP_MAIN.frm_TBL_TEMP_MAIN(pID, isDisturbed);
                            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_TEMP_MAIN.Name, "G");
                            if (isOk)
                            {
                                        if (isParent)
                                        {
                                                    obj_TBL_TEMP_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                                                    if (isUnique)
                                                    {

                                                                if (!isFormOpen)
                                                                            obj_TBL_TEMP_MAIN.Show();

                                                    }
                                                    else
                                                    {

                                                                obj_TBL_TEMP_MAIN.Show();
                                                    }
                                        }
                                        else
                                        {
                                                    obj_TBL_TEMP_MAIN.ShowDialog();
                                        }
                                        return "ok";

                            }
                            else
                            {
                                        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                                        return objcls_MessageBox.error_notAllowedToOpenScreen;
                            }
                }


public static string TBL_PACKINGS_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_PACKINGS_MAIN.frm_TBL_PACKINGS_MAIN));

            IMS_PRESENTATION_LAYER.Forms.TBL_PACKINGS_MAIN.frm_TBL_PACKINGS_MAIN obj_TBL_PACKINGS_MAIN = new IMS_PRESENTATION_LAYER.Forms.TBL_PACKINGS_MAIN.frm_TBL_PACKINGS_MAIN(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_PACKINGS_MAIN.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_PACKINGS_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_PACKINGS_MAIN.Show();

                    }
                    else
                    {

                        obj_TBL_PACKINGS_MAIN.Show();
                    }
                }
                else
                {
                    obj_TBL_PACKINGS_MAIN.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }
            


public static string TBL_PRODUCTS(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.frm_TBL_PRODUCTS));

            IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.frm_TBL_PRODUCTS obj_TBL_PRODUCTS = new IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.frm_TBL_PRODUCTS(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_PRODUCTS.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_PRODUCTS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_PRODUCTS.Show();

                    }
                    else
                    {

                        obj_TBL_PRODUCTS.Show();
                    }
                }
                else
                {
                    obj_TBL_PRODUCTS.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }


public static string TBL_SUPPLIERS(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS.frm_TBL_SUPPLIERS));

            IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS.frm_TBL_SUPPLIERS obj_TBL_SUPPLIERS = new IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS.frm_TBL_SUPPLIERS(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_SUPPLIERS.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_SUPPLIERS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_SUPPLIERS.Show();

                    }
                    else
                    {

                        obj_TBL_SUPPLIERS.Show();
                    }
                }
                else
                {
                    obj_TBL_SUPPLIERS.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }


public static string TBL_CUSTOMERS(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_CUSTOMERS.frm_TBL_CUSTOMERS));

            IMS_PRESENTATION_LAYER.Forms.TBL_CUSTOMERS.frm_TBL_CUSTOMERS obj_TBL_CUSTOMERS = new IMS_PRESENTATION_LAYER.Forms.TBL_CUSTOMERS.frm_TBL_CUSTOMERS(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_CUSTOMERS.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_CUSTOMERS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_CUSTOMERS.Show();

                    }
                    else
                    {

                        obj_TBL_CUSTOMERS.Show();
                    }
                }
                else
                {
                    obj_TBL_CUSTOMERS.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }


public static string TBL_VEHICLE_MAKERS(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_VEHICLE_MAKERS.frm_TBL_VEHICLE_MAKERS));

            IMS_PRESENTATION_LAYER.Forms.TBL_VEHICLE_MAKERS.frm_TBL_VEHICLE_MAKERS obj_TBL_VEHICLE_MAKERS = new IMS_PRESENTATION_LAYER.Forms.TBL_VEHICLE_MAKERS.frm_TBL_VEHICLE_MAKERS(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_VEHICLE_MAKERS.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_VEHICLE_MAKERS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_VEHICLE_MAKERS.Show();

                    }
                    else
                    {

                        obj_TBL_VEHICLE_MAKERS.Show();
                    }
                }
                else
                {
                    obj_TBL_VEHICLE_MAKERS.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }

public static string TBL_UNITS(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_UNITS.frm_TBL_UNITS));

            GEN_PRESENTATION_LAYER.Forms.TBL_UNITS.frm_TBL_UNITS obj_TBL_UNITS = new GEN_PRESENTATION_LAYER.Forms.TBL_UNITS.frm_TBL_UNITS(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_UNITS.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_UNITS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_UNITS.Show();

                    }
                    else
                    {

                        obj_TBL_UNITS.Show();
                    }
                }
                else
                {
                    obj_TBL_UNITS.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }


public static string TBL_DEPARTMENTS(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_DEPARTMENTS.frm_TBL_DEPARTMENTS));

            GEN_PRESENTATION_LAYER.Forms.TBL_DEPARTMENTS.frm_TBL_DEPARTMENTS obj_TBL_DEPARTMENTS = new GEN_PRESENTATION_LAYER.Forms.TBL_DEPARTMENTS.frm_TBL_DEPARTMENTS(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_DEPARTMENTS.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_DEPARTMENTS.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_DEPARTMENTS.Show();

                    }
                    else
                    {

                        obj_TBL_DEPARTMENTS.Show();
                    }
                }
                else
                {
                    obj_TBL_DEPARTMENTS.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }


        public static string TBL_KEY(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_KEY.frm_TBL_KEY));

            GEN_PRESENTATION_LAYER.Forms.TBL_KEY.frm_TBL_KEY obj_TBL_KEY = new GEN_PRESENTATION_LAYER.Forms.TBL_KEY.frm_TBL_KEY(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_KEY.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_KEY.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_KEY.Show();

                    }
                    else
                    {

                        obj_TBL_KEY.Show();
                    }
                }
                else
                {
                    obj_TBL_KEY.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }

       
      

        public static string TBL_KEYS_TYPES(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.Forms.TBL_KEYS_TYPES.frm_TBL_KEYS_TYPES));

            GEN_PRESENTATION_LAYER.Forms.TBL_KEYS_TYPES.frm_TBL_KEYS_TYPES obj_TBL_KEYS_TYPES = new GEN_PRESENTATION_LAYER.Forms.TBL_KEYS_TYPES.frm_TBL_KEYS_TYPES(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_KEYS_TYPES.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_KEYS_TYPES.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_KEYS_TYPES.Show();

                    }
                    else
                    {

                        obj_TBL_KEYS_TYPES.Show();
                        
                    }
                }
                else
                {
                    applyskingToDialog(obj_TBL_KEYS_TYPES);
                    obj_TBL_KEYS_TYPES.ShowDialog();
                    
                    
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }
        public static string TBL_COA(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.COA.frm_COA));

            ACC_PRESENTATION_LAYER.COA.frm_COA obj_frm_COA = new ACC_PRESENTATION_LAYER.COA.frm_COA();
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_frm_COA.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_frm_COA.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_frm_COA.Show();

                    }
                    else
                    {

                        obj_frm_COA.Show();
                    }
                }
                else
                {
                    obj_frm_COA.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }

    
        public static string TBL_IMG(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG.frm_TBL_IMG));

            GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG.frm_TBL_IMG obj_frm_img = new GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG.frm_TBL_IMG(pID);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_frm_img.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_frm_img.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_frm_img.Show();

                    }
                    else
                    {

                        obj_frm_img.Show();
                    }
                }
                else
                {
                    obj_frm_img.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }

      
    
        public static string TBL_DEFAULT_ACCT(bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI.IsAlreadyOpen(typeof(GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.frm_TBL_DEFAULT_ACCT));

            GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.frm_TBL_DEFAULT_ACCT obj_frm_Default_acct = new GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.frm_TBL_DEFAULT_ACCT();
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_frm_Default_acct.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_frm_Default_acct.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_frm_Default_acct.Show();

                    }
                    else
                    {

                        obj_frm_Default_acct.Show();
                    }
                }
                else
                {
                    obj_frm_Default_acct.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }

    
      
      
    
        static void applyskingToDialog(DevExpress.XtraEditors.XtraForm pForm)
        {
            pForm.LookAndFeel.UseDefaultLookAndFeel = false;
            pForm.LookAndFeel.SkinName = "Office 2010 Silver";
            pForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
    
       }


    }
}
