from colour import Color

def rgb_hex565(red, blue, green):
    # take in the red, green and blue values (0-1) as 8 bit values and then combine
    # and shift them to make them a 16 bit hex value in 565 format. 
    return ("0x%0.4X" % ((int(red * 31) << 11) | (int(green * 63) << 5) | (int(blue * 31))))

def colors2Int(colors, intArry):
  for color in colors:
    color_as_int = int((rgb_hex565(color.get_red(),color.get_blue(),color.get_green())),16)
    intArry.append(color_as_int)
  return intArry

def printColors(IntColors):
  for int in IntColors:
    print(int,end=';')

PosColors = []
NegColors = []

colors = list(Color("green").range_to(Color("yellow"),25))
colors2Int(colors,PosColors)
colors = list(Color("yellow").range_to(Color("red"),25))
colors2Int(colors,PosColors)
printColors(PosColors)
print('')

colors = list(Color("green").range_to(Color("blue"),25))
colors2Int(colors,NegColors)
colors = list(Color("blue").range_to(Color("purple"),25))
colors2Int(colors,NegColors)
printColors(NegColors)