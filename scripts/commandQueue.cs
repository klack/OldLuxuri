strlen commandQueue.txt,k //get the length of the command queue
while(k>0)
{
  click readBuffer,1
  if(ok==1)
  {
    spstr commandQueue.txt,vars.s.txt,"\r",0
    if(vars.s.txt!="")
    {
      strlen vars.s.txt,j //get the lenght of the command
      l=k-j //calc the amount of chars to copy
      //remove the command from the queue by getting a substring of the commandqueue
      substr commandQueue.txt,commandQueue.txt,j+2,l //+2 to count \r
      prints vars.s.txt,0
      printh 0A
      ok=0
    }else
    {
      commandQueue.txt=""
    }
  }
  strlen commandQueue.txt,k //get the length of the command queue
}
