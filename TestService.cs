using System;

namespace cxf
{
	public class TestService
	{
		public static void Main (string [] args)
		{
			testLists();
			testMaps();	
		}

		private static void testMaps(){
			RemoteReportServiceService service = new RemoteReportServiceService ();
			
			KeyValue[] maps = service.getMaps();	
			
			if (maps == null)
				Console.WriteLine("[No Data In Maps]");
			else	
				outputMap(maps);

		}

		private static void testLists ()
		{
			RemoteReportServiceService service = new RemoteReportServiceService ();
			
			remoteReport[] reports = service.getMeSomeReports();	
			
			if (reports == null)
				Console.WriteLine("[No Reports]");
			else	
				outputList(reports);
		}

		private static void outputList (remoteReport[] reports)
		{
			foreach(remoteReport report in reports){
				Console.WriteLine(report.reportId + " :: " + report.errorCode + " " + report.errorMessage);
			}
		}

		private static void outputMap (KeyValue[] maps)
		{
			foreach (KeyValue map in maps) {
				Console.WriteLine(map.key + " = " + map.value);
			}
		}
	}
}

