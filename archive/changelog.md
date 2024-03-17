0.9.2.1
Bugs Fixed:
#17 Screen not monitoring temperature changes set by Gcode
#50 Preheat button on occasion heats only bed
#145 Exiting the Level bed screen can crash extruder into front clips
#150 Move menu extrude button does not handle repeated press

Rudimentary support for Filament Runout
Fix incorrect display of temperature when E2 is selected
Seperate versions for different bed sizes no longer needed
Screen will now reconnect if an external reset is caused by plugging in USB
Fix commands being thrown out after waking from sleep
Fix PID Tune not starting fan
Reduced delays in set and read temperature

0.9.1
New console in Dark Mode
Console scrollback (touch and buttons)
Console filters
New GCode Keyboard
Preserve serial history
Record sent commands
New combined status bar (console page)
Fix delay in set temperature
Raise Z after bed level
Change PVA to ABS on preheat page
Increase PETG to 80 bed and 250 hotend
Read bedsize from M115 and utilize in Level Bed page

0.9
Change live z offset increment to 0.02

0.8
Add Live Z-Offset
Reduce Z height on level bed
Fix present forward after stop print
Disable motors after stop print

0.7.11
Fix PID Tune not saving

0.7.10
Fix direct X Y Z entry on move tool page

0.7.7
Fix freezing on file selector
Fix pause print causing z-height to raise (revert to storing XYZ coordinates)
Fix pre-heat not working on first button press (disabled skipping loading screen)
Fix print complete showing on wake every time
Fix connected at 0 message
Present bed forward after stop print
Reduce frequency of toasters