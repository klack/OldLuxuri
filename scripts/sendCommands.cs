///////////////////////////////////////////////////////////////////////////////
/// @fn luxSend 1
/// @brief Send a single command
/// @param[in] command.command.txt
///////////////////////////////////////////////////////////////////////////////
click debug,1
if(ok==1&&busy==0)
{
  prints commands.command.txt,0
  printh 0A
  ok=0
}else
{
  commands.queue.txt+=commands.command.txt
}
commands.command.txt=""

///////////////////////////////////////////////////////////////////////////////
/// @fn luxSend 0
/// @brief Send command queue, waiting for ok between each command
/// @brief Waits a max of 10 times for each ok
///////////////////////////////////////////////////////////////////////////////
if(ok==1&&busy==0)
{
  OkBlocks=0
  strlen commands.queue.txt,k //get the length of the command queue
  while(k>0&&OkBlocks<10)
  {
    doevents
    click luxRead,1
    if(ok==1&&busy==0)
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
        click luxSend,1
      }else
      {
        commands.queue.txt=""
        QueueBlocks=0
      }
    }else
    {
      click luxRead,1
      OkBlocks+=1
      click debug,1
      doevents
    }
    strlen commands.queue.txt,k
  }
  if(OkBlocks>=10)
  {
    QueueBlocks+=1 //Track how many times the queue was blocked
  }else
  {
    QueueBlocks=0
  }
}else
{
  strlen commands.queue.txt,j
  if(j>0)
  {
    QueueBlocks+=1
  }
}
if(QueueBlocks>10)
{
  prints "M118 marco",0 //Maybe an ok was missed, try and trigger one
  printh 0A
  QueueBlocks=0
}
click debug,1