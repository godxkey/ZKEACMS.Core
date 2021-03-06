/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using Easy.MetaData;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZKEACMS.Common.Models
{
    [Table("ScriptWidget")]
    public class ScriptWidget : BasicWidget
    {
        public string Script { get; set; }
    }

    class ScriptWidgetMetaData : WidgetMetaData<ScriptWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.StyleClass).AsHidden();
            ViewConfig(m => m.Script).AsTextArea().Order(NextOrder()).Required();
        }
    }
}