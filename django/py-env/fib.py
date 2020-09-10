def fib(n):
    if n == 1:
        return 0
    elif n == 2:
        return 1
    else: 
        return fib(n-1)+fib(n-2)

if __name__ == '__main__':
    import sys
    try:
        n = sys.argv[1]
    except IndexError:
        n = 1
    finally:
        print(fib(int(n)))