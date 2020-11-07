//Send Command
prints commands.command.txt,0
printh 0A
ok=0


//Send Queue
BlockCount=0
strlen commands.queue.txt,k //get the length of the command queue
while(k>0&&BlockCount<20) //Only try sending commands for 5 seconds
{
  doevents
  click readBuffer,1
  if(ok==1)
  {
    BlockCount=0
    spstr commands.queue.txt,vars.s.txt,"\r",0
    if(vars.s.txt!="")
    {
      strlen vars.s.txt,j //get the lenght of the command
      l=k-j //calc the amount of chars to copy
      //remove the command from the queue by getting a substring of the commandqueue
      substr commands.queue.txt,commands.queue.txt,j+2,l //+2 to count \r
      commands.command.txt=vars.s.txt
      click sendCommand,1
    }else
    {
      commands.queue.txt=""
    }
  }else
  {
    BlockCount+=1
    delay=250
  }
  strlen commands.queue.txt,k //get the length of the command queue
}
