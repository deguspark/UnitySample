include $(CLEAR_VARS)

LOCAL_ARM_MODE  := arm
LOCAL_PATH      := $(NDK_PROJECT_PATH)
LOCAL_MODULE    := libNative
LOCAL_CFLAGS    := -Werror
LOCAL_SRC_FILES := BuildNativeSo/Native.cpp
LOCAL_LDLIBS    := -llog

include $(BUILD_SHARED_LIBRARY)

