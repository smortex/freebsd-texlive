# $FreeBSD$

PORTNAME=	metafont
PORTVERSION=	20120529
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A system for specifying fonts.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
