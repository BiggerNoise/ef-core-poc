using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_core_poc.model 
{
    public enum ScriptRunAction
    {
        Run = 1,
        Rehash = 2,
    }

    [Table("scripts_run")]
    public class ScriptsRun
    {
        public long id { get; set; }
        public long version_id { get; set; }
        [StringLength(255)]
        public string script_name { get; set; }
        [Column(TypeName = "text")]
        public string text_of_script { get; set; }
        [StringLength(512)]
        public string text_hash { get; set; }
        public bool one_time_script { get; set; }

        //auditing
        public DateTime? entry_date { get; set; }
        public DateTime? modified_date { get; set; }
        [StringLength(50)]
        public string entered_by { get; set; }

        public ScriptRunAction run_action {get;set;}
    }
}