import sys

def main():
    try:
        animal = sys.argv[1]
    except IndexError:
        animal = 'dog'
    if animal == 'dog':
        print("woof")
    elif animal == 'cat':
        print("Meow")  

if __name__ == '__main__':
    main()
