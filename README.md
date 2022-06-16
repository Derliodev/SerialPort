# Programación de componentes de escritorio
En el presente informe hago entrega de las evidencias de mi trabajo en el desarrollo de lo requerido en la Evaluación 2 para el ramo de “Programación de componentes de escritorio”

## 1 EVIDENCIAS
### Modificar la velocidad de comunicación del Puerto COM donde estará comunicándose el módulo WIFI.
#### A1-. Primero verifico que exista conexión entre el dispositivo desde el puerto con un receptor de datos como Hercules.

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/1.png)

#### A2.- Luego envió un dato para demostrar que la comunicación es en sincronía

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/2.png)

#### A3.- Modifico la velocidad de comunicación con la app a 9600 BPS y verifico la perdida de sincronía

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/3.png)

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/4.png)

#### A3.- Vuelvo a dejar en la velocidad de comunicación sincrónica para seguir con la evaluación

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/5.png)

#### B.- Envió de comandos como cadena de string terminando con CR LF

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/6.png)

El cual es recibido y visualizado de la siguiente manera

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/7.png)

#### C.- Recibir la respuesta del modulo Wifi:

Si puede apreciar el código del repositorio que se adjunta, la configuración del mensaje de salida después de horas de revisada parece, no encuentro el problema, pero efectivamente el modulo envía Datos que son recogidos por este mismo pero no por el Receptor Hercules.

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/8.png)

(La verdad es que fue un poco frustrante el no encontrar la solución 🙁)


#### D.- Recibir carácter Ascii CR y mostrarlo en pantalla como `<CR>` y que termine línea de texto
![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/9.png)


#### E.- Informe de configuración de modulo como AP sin intervención Humana

Dando click en la opción de configuración, se envía un array con los datos al modulo que modifica su configuración al tipo AP (a la inversa no le apliqué funcionalidad)

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/10.png)

Evidencia de el modulo ya configurado y funcionando como AP

![](https://rkl5ulbb0wj8tjlwyrnn.katherineflores.ml/leo/11.png)
