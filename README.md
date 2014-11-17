ReportPhantom
=============

Activate Crystal Reports from D3 Database

This is my first attempt at a GitHub Project. I'm using it as a learning experience to learn how to use GitHub.

The Project itself is a C# process which sits in the background monitoring an INI file and producing 
Crystal Reports based on the parameters present in the INI file.

The INI file is currently hard-coded to \\SAPS-SVR01\Company\CrystalReports\ReportPhantom.ini. This will be softcoded
somehow in the future (but will suffice for developmental purposes).
The program polls the INI file about once a second to see if there is a CR report to be produced. If a CR filename
is provided it goes ahead and runs the CR report file using the provided options to print or export the generated report.

This project is far from complete and suffers from many bugs as I'm still learning C# as well. Use it at your own risk.
No warranties, expressed or implied are offered or given. No liabilities of any kind accepted or offered.
