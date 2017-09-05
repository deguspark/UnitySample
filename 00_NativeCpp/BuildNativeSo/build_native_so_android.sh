#!/bin/sh

set -e

ANDROID_NDK_ROOT=/Users/shogo/Library/Android/sdk/ndk-bundle/

$ANDROID_NDK_ROOT/ndk-build NDK_PROJECT_PATH=. NDK_APPLICATION_MK=Application.mk $*
rm -rf ../Assets/Plugins/Android/*
mv libs ../Assets/Plugins/Android/
rm -rf ./obj

