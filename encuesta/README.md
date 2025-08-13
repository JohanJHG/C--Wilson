# Responder Encuesta del Curso de C#

## Descripción

Este caso de uso permite que un participante evalúe el curso y registre una única respuesta.

---

## Actor Principal

- Participante del curso

## Objetivo

- Permitir que un participante evalúe el curso y se registre una única respuesta.

---

## Precondiciones

- El programa de encuesta está en ejecución.
- El participante no ha respondido previamente.

---

## Flujo Principal

1. El sistema muestra un menú con tres opciones:
    - Responder Encuesta
    - Ver Resultados
    - Salir
2. El participante selecciona la opción **Responder Encuesta**.
3. El sistema solicita:
    - Nombre
    - Calificación del contenido (1 a 5)
    - Calificación del instructor (1 a 5)
    - Calificación de la plataforma (1 a 5)
4. El participante ingresa los datos solicitados.
5. El sistema guarda la respuesta y bloquea la posibilidad de responder nuevamente.
6. El sistema confirma el registro exitoso.

---

## Flujo Alterno

- Si el participante intenta responder nuevamente, el sistema muestra un mensaje indicando que ya respondió.

---

## Postcondiciones

- La respuesta queda registrada en memoria.
- El usuario puede visualizar su respuesta en la opción **Ver Resultados**.
