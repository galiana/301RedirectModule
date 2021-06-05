using System;
using System.Text.RegularExpressions;
using System.Web;

namespace SharedSource.RedirectManager.Rules.Actions
{
    public class ReplaceStringAdvanced<T> : Sitecore.Rules.Actions.RuleAction<T> where T : Sitecore.Rules.RuleContext
    {
        public string Old { get; set; }
        public string New { get; set; }

        public override void Apply(T ruleContext)
        {
            if (ruleContext.Parameters["newUrl"] != null)
            {
                string str = (string)ruleContext.Parameters["newUrl"];
                ruleContext.Parameters["newUrl"] = Regex.Replace(str, Old, New, RegexOptions.IgnoreCase);
            }
        }
    }
}