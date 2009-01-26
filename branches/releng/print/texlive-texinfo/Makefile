# New ports collection makefile for:	texlive-texinfo
# Date created:		26/01/2009 16:11:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texinfo
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Texinfo documentation system.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
