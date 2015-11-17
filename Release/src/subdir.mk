################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/correct_pitch.c \
../src/note.c \
../src/pitch_detector.c \
../src/project.c \
../src/stats.c 

OBJS += \
./src/correct_pitch.o \
./src/note.o \
./src/pitch_detector.o \
./src/project.o \
./src/stats.o 

C_DEPS += \
./src/correct_pitch.d \
./src/note.d \
./src/pitch_detector.d \
./src/project.d \
./src/stats.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: C Compiler'
	$(CC) -I"pch" -I"$(PROJ_PATH)\inc" -O3 -g -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) $(RS_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -mthumb -I@system_includes -Werror-implicit-function-declaration -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


