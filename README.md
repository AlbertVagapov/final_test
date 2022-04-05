Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначально массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  


Примеры:

["Hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []


Решение:

Создаем два массива - array, secondarray. Из первого массива выбираем  элементы, которые соответствуют условию задачи, а во второй помещаем эти элементы. Создаем метод который сортирует массив и выбираем строки соответствующие условию. При обнаружении соответствия, элемент первого массива, записывается в переменную count. После того как записали элемент, count увеличиваем на 1 и переходим снова к циклу for в котором ind увеличивается на 1.