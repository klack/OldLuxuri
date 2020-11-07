spstr commandQueue.txt,vars.s.txt,"\r",0
//get the lenght of the command
strlen vars.s.txt,j
//get the length of the command queue
strlen commandQueue.txt,k
//calc the amount of chars to copy
l=k-j
//remove the command from the queue by getting a substring of the commandqueue
prints vars.s.txt,0
substr commandQueue.txt,commandQueue.txt,j+2,l //+1 to count \r
