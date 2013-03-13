# $FreeBSD$

PORTNAME=	installfont
PORTVERSION=	20130312
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A bash script for installing a LaTeX font family.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
