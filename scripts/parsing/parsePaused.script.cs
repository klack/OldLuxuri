parse.lineMatch.txt="echo:Insert filament and send M108" //Shutdown
strlen parse.lineMatch.txt,j
substr parse.buffer.txt,parse.eval.txt,0,j
if(parse.eval.txt==parse.lineMatch.txt)
{
  parse.buffer.txt=""
  bOk.y=180
  pause.message.txt="Insert filament"

}
parse.lineMatch.txt="echo:Send M108 to heat nozzle" //Shutdown
strlen parse.lineMatch.txt,j
substr parse.buffer.txt,parse.eval.txt,0,j
if(parse.eval.txt==parse.lineMatch.txt)
{
  parse.buffer.txt=""
  bOk.y=180
  pause.message.txt="Press OK to heat extruder"
}
parse.lineMatch.txt="//action:resumed" //Shutdown
strlen parse.lineMatch.txt,j
substr parse.buffer.txt,parse.eval.txt,0,j
if(parse.eval.txt==parse.lineMatch.txt)
{
  commands.pauseAction.val=0
  parse.buffer.txt=""
  page DiagReturnPage
}