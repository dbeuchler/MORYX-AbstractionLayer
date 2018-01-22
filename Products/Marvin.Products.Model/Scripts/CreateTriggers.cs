﻿using System;
using System.Collections.Generic;
using System.Text;
using Marvin.Model;

namespace Marvin.Products.Model
{
	/// <summary>
	/// MARVIN Script class to generate triggers for generated tables                                       
	/// This is autogenerated code, therefor any modifications are useless and will be lost on recreation. 
	///                                                                                                    
	/// If you have questions or modification requests contact Thomas Fuchs.                               
	/// </summary>
	internal class ProductsTriggerScript : IDatabaseScript
	{
		public string Name { get { return "ProductsTriggerScript"; } }

		public bool IsCreationScript { get { return true; } }

		public string GetText()
		{
			var script = new StringBuilder();
			script.AppendLine(GetProcedure());
			#pragma warning disable 219
			// Add trigger on date time enhanced tables
			// ReSharper disable once UnusedVariable
			const string triggerCommand = "CREATE TRIGGER update_{0} BEFORE INSERT OR UPDATE ON \"{0}\" " +
										  "FOR EACH ROW EXECUTE PROCEDURE set_timestamps();";
			#pragma warning restore 219
			script.AppendLine(string.Format(triggerCommand, "ProductEntity"));
			script.AppendLine(string.Format(triggerCommand, "ProductRecipeEntity"));
			script.AppendLine(string.Format(triggerCommand, "ProductProperties"));
			script.AppendLine(string.Format(triggerCommand, "WorkplanEntity"));
			script.AppendLine(string.Format(triggerCommand, "ProductDocument"));
			script.AppendLine(string.Format(triggerCommand, "StepEntity"));

			return script.ToString();	
		}

		private string GetProcedure()
		{
			var proc = 
@"CREATE OR REPLACE FUNCTION set_timestamps()	
RETURNS TRIGGER AS $$
BEGIN
	IF NEW.""Created"" IS NULL THEN
	   NEW.""Created"" = LOCALTIMESTAMP;
  END IF;

	NEW.""Updated"" = LOCALTIMESTAMP;

  IF NEW.""Deleted"" IS NOT NULL THEN
     NEW.""Deleted"" = LOCALTIMESTAMP;
  END IF;

  RETURN NEW;	
END;
$$ language 'plpgsql';
";
			return proc;
		}
	}
}
