# Tandero_Equipo
DESCRIPCIÓN:
    Tandero es una aplicación de escritorio desarrollada en C#. La aplicación te permite registrarte como usuario para poder ser organizador o participante de "tandas". Cada usuario cuenta con un rating de organizador y participante, para asegurar que la calidad del servicio.

    Con el perfil de organizador, se pueden crear y organizar nuevas tandas. Las tandas generan un código único que permite que otros participantes puedan unirse a ella desde el apartado de unir a tanda.
ESTRUCTURA:
    Perfil:
        En el boton de Perfil podras consultas información personal como:
            -Nombre.
            -Correo.
            -Rating de Organizador.
            -Rating de Participante.

    Tandas:
        Desde el apartado de Creación de Tandas podras:
            -Nombre de Tanda.
            -Agregar fecha de inicio de tanda.
            -Monto.
            -Número de Participantes.
            -Código único para que se puedan dar de alta en tú tanda.

        Dentro del campo de Organizador:
            -Podrias Revisar los usuarios dentro de tu tanda.
            -En caso de que todos los usuarios ya hayan cobrado su tanda esta se puede eliminar.
                    
        Dentro del campo de Participante:
            -Podrias observar las tandas actuales.
                        *Puedes interactuar con estas para observar a los participantes, los dias de pago y el monto de la tanda.
            -Agregarte a una tanda nueva a travez de un codigo comp.
            -Asignar un rating a el organizador de la tanda.

Instrucciones de compilación:
    Contar al menos con Visual Studio Community y las configuraciones de Windows Forms con C#.
