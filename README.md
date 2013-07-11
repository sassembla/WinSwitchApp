#SwitchApp

Switch application focus commandline exe for Windows7,8


##usage
	SwitchApp.exe -f PROCESS_NAME_OF_APP_1 -t PROCESS_NAME_OF_APP_2
	
First set focus to PROCESS_NAME_OF_APP_1, then set focus to PROCESS_NAME_OF_APP_2.

The focus interval is fixed as 1000ms.

PROCESS_NAME can check with TaskManager.  
for example "Sublime Text 3"'s PROCESS_NAME is "sublime_text".

##tips
-t PROCESS_NAME_OF_APP_2 is not necessary.