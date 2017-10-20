using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTracking.Core
{
    public enum CacheTime
    {
        None = 0,
        S = 15,
        M = 60,
        L = 180,
        XL = 1440
    }

    public enum AttributeType
    {
        [Description("Kural Sahibi")]
        RuleOwner = 1,
    }

    public enum Rules
    {
        [Description("Beklemede")]
        Waiting = 1,

        [Description("Sahada")]
        Field = 2,

        [Description("Rampada")]
        InRamp = 3,

        [Description("Evrak Onaylandı")]
        Field_DocumentCheck = 4,

        [Description("Evrak Onaylanmadı")]
        Field_DocumentNotCheck = 5,

        [Description("Rampaya Yönlendirildi")]
        Field_DirectedRamp = 6,

        [Description("İşlemde")]
        InRamp_Enter = 7,

        [Description("Beklemede")]
        InRamp_Waiting = 8,

        [Description("Tamamlandı")]
        InRamp_Out = 9
    }

    public enum TruckTypes
    {
        [Description("Tır")]
        Truck = 1,
        [Description("Kamyon")]
        Lorry = 2,
        [Description("Kamyonet")]
        Van = 3,
        [Description("Konteyner")]
        Container
    }

    public enum OperationTypes
    {
        [Description("Yüklemede")]
        Loading = 1,
        [Description("Boşaltmada")]
        Unloading
    }

    public enum ShippingFirms
    {
        [Description("Sertrans")]
        Sertrans = 1,
        [Description("Diğer")]
        Other
    }

    public enum OrganizationFirms
    {
        [Description("Sertrans")]
        Sertrans = 1,
        [Description("Diğer")]
        Other
    }

    public enum LogisticTypes
    {
        I = 1,
        E
    }
}
