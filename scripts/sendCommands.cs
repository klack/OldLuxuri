//Send Command
if(busy==0)
{
  prints commands.command.txt,0
  printh 0A
  ok=0
}else
{
  commands.queue.txt+=commands.command.txt
}
commands.command.txt=""

//Send Queue
OkBlocks=0
strlen commands.queue.txt,k //get the length of the command queue
while(k>0&&OkBlocks<500)
{
  doevents
  click readBuffer,1
  if(ok==1)
  {
    OkBlocks=0
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
      QueueBlocks=0
    }
  }else
  {
    click readBuffer,1
    OkBlocks+=1
    click debug,1
    doevents
  }
  strlen commands.queue.txt,k //get the length of the command queue
}
if(OkBlocks>=50)
{
  QueueBlocks+=1
}else
{
  QueueBlocks=0
}
if(QueueBlocks>500)
{
  commands.command.txt="M27" //Maybe an ok was missed, try and trigger one
  click sendCommand,1
  QueueBlocks=0
}