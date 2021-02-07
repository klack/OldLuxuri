import re
from faker import Faker
from faker.providers import company

def main():
    Faker.seed(0)
    fake = Faker()
    path_prefix = "./files/"
    for i in range(255):
        phrase = fake.catch_phrase()
        phrase = re.sub('[^A-Za-z0-9\s]+', '', phrase)
        f = open(F"{path_prefix}{i} - {phrase}.gcode", "w+")
        f.write("M117 Printing...\r")
        f.write("G28 X Y\r")
        f.write(F"M117 {phrase}\r")
        f.write("M109 T0 S90\r")
        f.write("G28 X Y\r")
        f.write(F"M117 {fake.company()}\r")
        f.write("G28 X Y\r")
        f.write(F"M117 Finished...\r")
        f.write("M104 T0 S0\r")
        f.close()


if __name__ == "__main__":
    main()
