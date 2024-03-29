import sys
def sqrt(x):
    '''
    Compute square using the method 
    of Heron of Alexandria

    Args:
        x: The nuber for wich the square root
            is to be computed.
        
        Returns:
            The square root of x.

        Raises:
            ValueError: If x is negative
    '''
    guess = x
    if x < 0:
        raise ValueError(f'Cannot compute square root of a negative number {x}')
    i = 0
    while guess * guess != x and i < 20:
        guess = (guess + x / guess)  / 2.0
        i += 1
    return guess


def main():
    try:
        print(sqrt(9))
        print(sqrt(2))
        print(sqrt(-1))
        print('This is never printed')
    except ValueError as e:
        print(e,file=sys.stderr)
    print("Program execution continues normally here.")
    

if __name__ == '__main__':
    main()