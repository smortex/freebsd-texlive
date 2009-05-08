
TARGET=		TLPort.exe
CSFILES=	TLPort.cs IPackage.cs Package.cs PackageCollection.cs

TLPOBJDIR?=	/home/romain/Desktop/TeXLive/local/tlpkg/tlpobj
PORTSDIR?=	/home/romain/Projects/freebsd-texlive

MCS=		gmcs
MCS_FLAGS=

MONO=		mono
MONO_FLAGS=

all: ${TARGET}

run: ${TARGET}
	${MONO} ${MONO_ARGS} ${TARGET} ${TLPOBJDIR} ${PORTSDIR}

${TARGET}: ${CSFILES}
	${MCS} ${MCS_FLAGS} -out:${.TARGET} ${.ALLSRC}

clean:
	rm -f ${TARGET}
