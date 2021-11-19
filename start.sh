#install-pkg nasm gcc mcs lua5.3

nasm -f elf64 ./h.asm
gcc -c e.c
ld -dynamic-linker /lib64/ld-linux-x86-64.so.2 -s -lc -o h e.o h.o
./h
