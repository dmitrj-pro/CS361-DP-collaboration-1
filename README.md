# CS361-DP-collaboration-1
Архитектура:
	В папке Kassa находится вся основная реализация программы.
	
	Kassa\USER - здесь находится интерфейсы работы с :
		базой пользователей
		с пользователем
	
	Kassa\Shop - содержит реализацию системы управления корзиной и покупкой

	Kassa\Shop\Card - Содержит реализацию скидочных карт

	Kassa\Shop\Goods - Реализация товаров

Необходимые файлы:
	
	bin\Debug\allCommand.txt - Список всех команд с их идентификаторами

	bin\card_base.txt - Список пользователей, у которых есть карта. Также указана сумма, которую они потратили

	bin\goods_base.txt - Список товаров, доступных для покупки

	bin\test_file.txt - файл с командами для отладки

	bin\userBD.txt - база данных пользователей


Паттерны:
	Kassa\Card\SuperCard - абстрактная фабрика. Данный класс по указанному пользователю возвращает его скидочную карту

	Kassa\Card\SuperCard - Одиночка. Через статичный метод возвращает содержимое всего класса

	Kassa\User\UsersBD - Либо строитель, либо фабрика

	Kassa\Kassa - Строитель
	

Список команд:

	login <login> <password> - авторизоваться по логину и адресу электронной почты (можно пароль)

	reg <login> <password> - зарегистрироваться

	get_Name - получить свое имя

	get_Mail - узнать свой пароль/почту. Зависит от интерпритации

	add - добавить товар в корзину по имени

	check - посмотреть на пробный чек

	exit - завершить работу

	buy - приобрести товары

	commit - заблокировать добавление товаров в корзину

	list - список товаров, доступных в магазине

	order - список товаров, лежащих в корзине

Вклады разработчиков:

	Проскурин Дмитрий - сделал всю реализацию, придумал структуру

	Нечаев Вадим - ничего (переименовал несколько функций, из-за того, что я ошибся в грамматике)
