#!/bin/sh

ndk-build NDK_PROJECT_PATH=. NDK_APPLICATION_MK=Application.mk $*

mv libs ../../Assets/Plugins/Android/libs
rm -rf libs
rm -rf obj

