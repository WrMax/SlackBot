﻿# Пример бота для Slack
По любой команде отправляет сообщение hello
## Настройка
Создайте команду для своего бота. Сгенерируйте пользователя бота, чтобы получить token.
Скорректируйте token в контроллере BotController
### вариант 1
Опубликовать на сервере с https, затем настроить адрес для команды бота;
### вариант 2
Запустите на локальной машине с помощью Visual Studio, затем в меню Tools -> Start ngrok tunnel
полученный от ngrok адрес укажите для команды бота
### вариант 3
Вариант совмещает первые два, нужно купить платное доменное имя в ngrok. Адрес укажите для команды бота.
Бот заработает после запуска на локальной машине и вызове команды Tools -> Start ngrok tunnel
