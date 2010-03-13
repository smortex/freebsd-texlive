# New ports collection makefile for:	texlive-texsis
# Date created:		13/03/2010 04:30:54
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texsis
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Plain TeX macros for Physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
