tDebug.txt="ok:"
covx ok,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="bsy:"
covx busy,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="\r"
tDebug.txt+="blkok:"
covx OkBlocks,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="q:"
covx QueueBlocks,vars.s.txt,0,0
tDebug.txt+=vars.s.txt
tDebug.txt+="\rlast:\r"
tDebug.txt+=commands.last.txt
tDebug.txt+="\rqueue:\r"
tDebug.txt+=commands.queue.txt
tDebug.txt+="\rhistory:\r"
tDebug.txt+=commands.history.txt
tDebug.txt+="--END--"
