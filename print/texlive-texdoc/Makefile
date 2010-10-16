# New ports collection makefile for:	texlive-texdoc
# Date created:		13/03/2010 04:24:27
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texdoc
PORTVERSION=	20101016
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Documentation access for TeX distributions.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
