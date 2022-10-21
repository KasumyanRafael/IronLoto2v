# ТЗ Касумян Рафаэль.

* Проект Осетинское лото.

Данная игра способствует изучению осетинского языка в игровой форме, рассчитана на детей школьного возраста, изучающих родной язык. Несмотря на то, что основной функцией приложения является обучение, оно идеально подойдёт для любого, кто желает провести время с удовольствием и с хорошей компанией. В неё можно играть на перемене с одноклассниками, на улице с друзьями, но только не во время урока или пары!
Игра рассчитанна на двух игроков, состоит из трёх раундов, по результатом которых определяется победитель. 
На первом уровне игрокам будет отведено по клетчатому полю, ячейки которого будут заполнены картинками с осетинскими подписями. Как и в обычном лото, игроки будут видеть в специальном окне картинку с русской подписью, только роль ведущего будет играть компьютер. Эта картинка меняется каждые 10 секунд, за это время игрок должен определить, есть ли аналогичное изображение в его таблице или нет. Если есть, то он вправе отметить её, если же он нажмёт на картинку, не имеющую ничего общего с той, которая находится в окне, игра оповестит об этом, обмануть систему не получится. За каждый правильный ответ участник получает по баллу (максимально-6), главное помнить, что у конкурента в таблице может быть такая же картинка и если тот отметит у себя её раньше, то вы уже не сможете это сделать, так как компьютер поменяет изображение в окне и обновит тайимер. Смысл в конкуренции! Выигрывает раунд тот участник игры, который быстрее своего противника очистит свою таблицу от каких-либо слов, либо имеет больше баллов, если компьютер перечислил все слова (когда игроки из-за невнимательности пропускают нужные им картинки).
Остальные раунды имеют тот же принцип работы, только во втором компьютер показывает картинки без подписей, а в третьем в таблицах вместо картинок будут просто осетинские слова.

Победил в игре тот, кто набрал по результатам игры больше всех баллов. В конце будет приведена таблица с баллами игроков.

Сложности игре добавит невозможность работать мышкой в этих раундах(один игрок для перемещения по своему полю использует стандартные кнопки “W”,”A”,”S”,”D”, другой-клавиши 8 4 2 6 цифровой клавиатуры. Для того, чтобы отметить картинку, первый игрок использует пробел, а второй- клавишу 5 цифровой клавиатуры). 


* Функционал:
1. Авторизация
2. Прохождение раунда
   2.1 Отрисовка клетчатых полей (класс)
   2.2 Запуск таймера с картинками
   2.3 Проверка выбранных игроками картинок, начисление баллов за правильные ответы
   2.4 Хроший подсчёт результатов
   2.5 Выбор локального победителя и переход на раунд выше (если раунд не последний)
3. Выбор победителя игры
4.Демонстрация результатов игры.


* Этапы реализации:

Версия 1.0


1.09.2022
Создать главную форму с кнопками игры, настроек,выхода.

6.09.2022  
Добавление таймера в игру

8.09.2022
Создать форму для авторизации игроков. 

10.09.2022
Ввести форму первого раунда со всем функционалом.

11.09.2022 
Ввести форму второго раунда со всем описанным функционалом.

12.09.2022
Ввести третий раунд

12.09.2022 
Вывод победителя, занесение результатов в таблицу

13.09.2022
Усиление конкуренции между игроками

16.09.2022
Устранение багов в таймере

18.09.2022
Внешнее обновление первого раунда, сжатие картинок с 300 до 236

19.09.2022
Внешнее обновление оставшихся раундов

30.09.2022
Постепенный отказ от длинного кода в пользу внедрения ООП. Создание класса GameUser.

1.10.2022
Класс GameField

7.10.2022
Создание классов WordExtract и Card.

Версия 2.0

10.10.2022
Класс Switcher, переключающий картинки. Устранение ошибок.

15.10.2022
Настраивание Switcher, появление багов в таймере

Ссылка на документ: https://docs.google.com/document/d/115HOOKC8THd5lYVwsKt7R-14hGU0Dvq_SUQSAQ9LyIg/edit#heading=h.gjdgxs



Ссылка на презентацию: https://docs.google.com/presentation/d/1H-9yBuKbMrasabpaP6SkaKygYZ0sQ1I-O2C6pe1379o/edit#slide=id.p


      
