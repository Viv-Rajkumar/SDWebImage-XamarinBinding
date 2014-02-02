# Update TARGET to corresponding project
TARGET=SDWebImage

XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/$(TARGET).xcodeproj
LIBNAME=lib$(TARGET)

all: $(LIBNAME)SDK.a

$(LIBNAME)-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/$(LIBNAME).a $@

$(LIBNAME)-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/$(LIBNAME).a $@

$(LIBNAME)SDK.a: $(LIBNAME)-i386.a $(LIBNAME)-armv7.a
	lipo -create -output $(PROJECT_ROOT)/build/$@ $^
	-mv $(PROJECT_ROOT)/$(LIBNAME)-i386.a $(PROJECT_ROOT)/build/$(LIBNAME)-i386.a
	-mv $(PROJECT_ROOT)/$(LIBNAME)-armv7.a $(PROJECT_ROOT)/build/$(LIBNAME)-armv7.a

clean:
	-find . -name "*.a" -delete