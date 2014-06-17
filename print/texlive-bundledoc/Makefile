# $FreeBSD$

PORTNAME=	bundledoc
PORTVERSION=	20140418
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Bundle together all the files needed to build a LaTeX document.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
