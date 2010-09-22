# New ports collection makefile for:	texlive-tie
# Date created:		13/03/2010 04:24:31
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	tie
PORTVERSION=	20100922
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Allow multiple web change files.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
