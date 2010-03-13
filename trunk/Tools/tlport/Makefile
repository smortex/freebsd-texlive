
TARGET=		TLPort.exe
CSFILES=	TLPort.cs IPackage.cs Package.cs PackageCollection.cs

TLPOBJDIR?=	/home/romain/Projects/freebsd-texlive/ftp
PORTSDIR?=	/home/romain/Projects/freebsd-texlive

MCS=		gmcs
MCS_FLAGS=

MONO=		mono
MONO_FLAGS=

all: ${TARGET}

run: ${TARGET}
	${MONO} ${MONO_ARGS} ${TARGET} ${TLPOBJDIR} ${PORTSDIR}

${TARGET}: ${CSFILES} NDesk.Options.dll
	${MCS} ${MCS_FLAGS} -out:${.TARGET} ${CSFILES} -pkg:ndesk-options

NDesk.Options.dll:
	cp `pkg-config --variable=Libraries ndesk-options` ${.TARGET}

clean:
	rm -f ${TARGET} NDesk.Options.dll
