# QuickSort

***

        -------===================== Q U I C K    S O R T =====================--------
      start = 0, end = 6, [17, 51, 41, 33, 29, 81, 97]
         диапазон от 0 до 6, метка на #0:
            цикл: 17 (0) меньше 97 (6) => МЕНЯЕМ 17 (меченый 0) и 17 (текущий 0):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #1
            цикл: 51 (1) меньше 97 (6) => МЕНЯЕМ 51 (меченый 1) и 51 (текущий 1):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #2
            цикл: 41 (2) меньше 97 (6) => МЕНЯЕМ 41 (меченый 2) и 41 (текущий 2):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #3
            цикл: 33 (3) меньше 97 (6) => МЕНЯЕМ 33 (меченый 3) и 33 (текущий 3):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #4
            цикл: 29 (4) меньше 97 (6) => МЕНЯЕМ 29 (меченый 4) и 29 (текущий 4):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #5
            цикл: 81 (5) меньше 97 (6) => МЕНЯЕМ 81 (меченый 5) и 81 (текущий 5):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #6
         ОБМЕН ВНЕ ЦИКЛА: 97 (меченый 6) и 97 (последний 6):
                      [17, 51, 41, 33, 29, 81, 97],  возврат метки #6
       ВХОД в рекурсию recSsort(array, start, pivot - 1)
      start = 0, end = 5, [17, 51, 41, 33, 29, 81, 97]
         диапазон от 0 до 5, метка на #0:
            цикл: 17 (0) меньше 81 (5) => МЕНЯЕМ 17 (меченый 0) и 17 (текущий 0):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #1
            цикл: 51 (1) меньше 81 (5) => МЕНЯЕМ 51 (меченый 1) и 51 (текущий 1):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #2
            цикл: 41 (2) меньше 81 (5) => МЕНЯЕМ 41 (меченый 2) и 41 (текущий 2):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #3
            цикл: 33 (3) меньше 81 (5) => МЕНЯЕМ 33 (меченый 3) и 33 (текущий 3):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #4
            цикл: 29 (4) меньше 81 (5) => МЕНЯЕМ 29 (меченый 4) и 29 (текущий 4):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #5
         ОБМЕН ВНЕ ЦИКЛА: 81 (меченый 5) и 81 (последний 5):
                      [17, 51, 41, 33, 29, 81, 97],  возврат метки #5
       ВХОД в рекурсию recSsort(array, start, pivot - 1)
      start = 0, end = 4, [17, 51, 41, 33, 29, 81, 97]
         диапазон от 0 до 4, метка на #0:
            цикл: 17 (0) меньше 29 (4) => МЕНЯЕМ 17 (меченый 0) и 17 (текущий 0):
                      [17, 51, 41, 33, 29, 81, 97], НОВАЯ метка на #1
            цикл: 51 (1) НЕ меньше 29 (4) => НЕТ обмена #1 = 51 c #1 = 51
            цикл: 41 (2) НЕ меньше 29 (4) => НЕТ обмена #1 = 51 c #2 = 41
            цикл: 33 (3) НЕ меньше 29 (4) => НЕТ обмена #1 = 51 c #3 = 33
         ОБМЕН ВНЕ ЦИКЛА: 29 (меченый 1) и 51 (последний 4):
                      [17, 29, 41, 33, 51, 81, 97],  возврат метки #1
       ВХОД в рекурсию recSsort(array, start, pivot - 1)
      start = 0, end = 0, [17, 29, 41, 33, 51, 81, 97]
       ВХОД в рекурсию recSsort(array, pivot + 1, end)
      start = 2, end = 4, [17, 29, 41, 33, 51, 81, 97]
         диапазон от 2 до 4, метка на #2:
            цикл: 41 (2) меньше 51 (4) => МЕНЯЕМ 41 (меченый 2) и 41 (текущий 2):
                      [17, 29, 41, 33, 51, 81, 97], НОВАЯ метка на #3
            цикл: 33 (3) меньше 51 (4) => МЕНЯЕМ 33 (меченый 3) и 33 (текущий 3):
                      [17, 29, 41, 33, 51, 81, 97], НОВАЯ метка на #4
         ОБМЕН ВНЕ ЦИКЛА: 51 (меченый 4) и 51 (последний 4):
                      [17, 29, 41, 33, 51, 81, 97],  возврат метки #4
       ВХОД в рекурсию recSsort(array, start, pivot - 1)
      start = 2, end = 3, [17, 29, 41, 33, 51, 81, 97]
         диапазон от 2 до 3, метка на #2:
            цикл: 41 (2) НЕ меньше 33 (3) => НЕТ обмена #2 = 41 c #2 = 41
         ОБМЕН ВНЕ ЦИКЛА: 33 (меченый 2) и 41 (последний 3):
                      [17, 29, 33, 41, 51, 81, 97],  возврат метки #2
       ВХОД в рекурсию recSsort(array, start, pivot - 1)
      start = 2, end = 1, [17, 29, 33, 41, 51, 81, 97]
       ВХОД в рекурсию recSsort(array, pivot + 1, end)
      start = 3, end = 3, [17, 29, 33, 41, 51, 81, 97]
       ВХОД в рекурсию recSsort(array, pivot + 1, end)
      start = 5, end = 4, [17, 29, 33, 41, 51, 81, 97]
       ВХОД в рекурсию recSsort(array, pivot + 1, end)
      start = 6, end = 5, [17, 29, 33, 41, 51, 81, 97]
       ВХОД в рекурсию recSsort(array, pivot + 1, end)
      start = 7, end = 6, [17, 29, 33, 41, 51, 81, 97]
          
***
