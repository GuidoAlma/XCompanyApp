# XCompanyApp
Aplicación solicitada por empresa X

#Tradeoffs conocidos
* IPermisosRepository y ITipoPermisoRepository deberían ser inyectados en PermisosController para hacer el controlador testeable.
* IPermisosRepository y ITipoPermisoRepository deberían estar implementados con el patron unit of work para soportar transacciones
* Se podría separar la lógica relativa a TipoPermisos a un controlador a parte
* Se puede validar al intentar remover un TipoPermiso si tiene alguna relación creada en Permisos
* Las llamas a la creación de permiso y al borrado de tipo permiso deberían hacerse desde el FE con una llamada ajax para poder mostrar un mensaje de error al usuario en caso de que fallen (y en caso de éxito eventualmente también)
* La validación en el FE de la creación de permisos es básica (solo evita el posteo del formulario). Se puede mejorar mostrando al usuario cual es el campo que debe corregir.
* La UI de la app es básica y tomada del template básico de MVC de Visual Studio. Deberían ser depuradas las cosas innecesarias y se puede mejorar notablemente. 
