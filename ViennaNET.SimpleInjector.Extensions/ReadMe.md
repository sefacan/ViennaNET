﻿# Сборка, обеспечивающая подключение SimpleInjector в качестве DI/IoC в приложение

Для корректной работы конфигуратора в .csproj сборки с сервисом необходимо добавить строку
     
     <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>

Она предписывает при сборке копировать сборки из скачанных nuget-пакетов в выходную папку, чтобы SimpleInjector смог их увидеть и зарегистрировать сервисы в контейнере.
