while True:
    radius=float(input('Please input Radius: '))
    PI=3.14159265358
    perimeter=2*PI*radius
    area=PI*(radius**2)
    print('Perimeter=',perimeter,'\n','Area=',area)
    again=str(input('again?'))
    if(again!='y'):
        break
    else:
        continue

