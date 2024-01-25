# Ural_CS

<img src="https://github.com/RusMermaid/Ural_CS/blob/main/resources/logo/Sizes/UralLogoBackground1024.png">

>  Ural.Net is an endeavor aimed at the development of an object-oriented and functional programming language with a rigorous static typing system, all designed to be implemented in the any of the human languages. This project represents a significant effort in advancing the field of programming languages, combining the power of object-oriented design with the clarity and precision of strict static typing and combinatory logic. The first languages targeted are English, Russian and Greek. Disclamer: this is not anything political

## Datatypes
Numeric/Числовые:
<table>
<tr>
<th> English </th>
<th> Русский </th>
</tr>
<tr>
<td>

- nat16, nat32, nat64 - ℕ numbers from 0 to 2^s - 1, s is the end number
- whl16, whl32, whl64 - ℤ numbers from -2^s to 2^s - 1, s is the end number
- real16, real32, real64 - ℝ numbers from -2^s to 2^s - 1, s is the end number
- RCI - boolean: TRUE or FALSE

</td>
<td>

- натч16, натч32, натч64 - ℕ числа от 0 до 2 в степени последнего числа
- целч16, целч32, целч64 - ℤ числа c абсолютным максимальном 2 в степени последнего числа
- дробч16, дробч32, дробч64 - ℝ числа c абсолютным максимальном 2 в степени последнего числа
- РЦЫ - булевы которые имеют только два значения: ИСТИНА или ЛОЖЬ

</td>
</tr>
</table>

String/Строчные:
<table>
<tr>
<th> English </th>
<th> Русский </th>
</tr>
<tr>
<td>

- str0 - character
- str10 - default string type with max length of 1024, raw string
- str16, str32, str64 - strings with length 2^s, s is the end number
</td>
<td>

- стр0 - строчка в 1 символ
- стр10 - строчки с максимальной длинной 1024
- стр16, стр32, стр64 - строчки с максимальной длинной 2 в степени последнего числа

</td>
</tr>
</table>

Collections/Коллекции:
<table>
<tr>
<th> English </th>
<th> Русский </th>
</tr>
<tr>
<td>

- arraylist< Type > - mutable array with a data type
- list - mutable list
- tuple - immutable list
- stack<Type> - mutable stack
- order - mutable queue
- hash<Type1, Type2> -  mutable bi-directional hashtable with data types
</td>
<td>

- массив<тип значений> - изменяемый массив с любым кол-вом элементов, но со строгой тизацией
- список - изменяемый список с любым кол-вом элементов и без тизацией
- кортеж - не изменяемый список с любым кол-вом элементов и без тизацией
- стэк<тип значений> - изменяемый список с любым кол-вом элементов и без тизацией. Добавлять и удалять элементы можно только с конца
- очередь - изменяемый список с любым кол-вом элементов и без тизацией. Добавлять и удалять элементы можно только с начала
- хэш<тип ключей, тип значений> - словарь или хэш таблица, работает как пара ключ : значение

</td>
</tr>
</table>

Extra/Дополнительные:
<table>
<tr>
<th> English </th>
<th> Русский </th>
</tr>
<tr>
<td>

- cmplx - ℂ numbers based on matrica data type and real64 datatype
- matrica - 𝕄 mathematrical matrix
- lambda - generator
- kappa - combinator record datatype for functional programming
</td>
<td>

- кмпл - ℂ числа c ограничениями как у дробч64
- матрица - 𝕄 изменяемый двумерный список который ведет себя как математическая матрица
- лямбда - генератор списков или других коллекций
- каппа - комбинаторы И, С, К, Ц, В и М (из лямбда анализа)

</td>
</tr>
</table>


