def print_operation_table(operation, num_rows=6, num_columns=6):
    for i in range(1, num_rows + 1):
        answer = []
        for j in range(1, num_columns + 1):
            answer.append(str(operation(i, j)))
        print(''.join(f'{e:<4}' for e in answer))


print_operation_table(lambda x, y: x * y)