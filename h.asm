extern main
section		.text
	global		 _start
_start:
	mov		edx,len
	mov		ecx,msg
	mov		ebx,1 
	mov		eax,4 
	int		0x80                                
	call	main	
	mov		eax,1         
	int		0x80                               
section		.data
	msg		db 'H',0xa                
	len		equ $ - msg